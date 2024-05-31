using forms.Models;
using forms.Views.Interfaces;
using Linkedin_Automation.Model;
using MessagePack;

namespace forms.Presenters
{
    public class LoginPresenter
    {
        //Fields
        private ILoginView _loginView;
        private ILoginRepository _loginRepository;
        private string filePath = "../../../Files/user.msgpack";

        public LoginPresenter(ILoginView loginView, ILoginRepository loginRepository)
        {
            _loginView = loginView;
            _loginRepository = loginRepository;
            _loginView.LoginEvent += LoginEvent;
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // Cria o arquivo se não existir
            if (!File.Exists(filePath))
            {
                _loginRepository.create(filePath);
            }
            else //Arquivo já existente
            {
                // Lê o conteúdo do arquivo
                byte[] fileBytes = _loginRepository.read(filePath);

                //Arquivo vazio
                if (fileBytes.Length == 0)
                {
                    // preenche com dados da classe User
                    User user = new User(_loginView.Email, _loginView.Password);
                    _loginRepository.edit(filePath, user);
                }
                else //Arquivo cheio
                {
                    // Desserializa os bytes em um objeto User
                    var loadedUser = MessagePackSerializer.Deserialize<User>(fileBytes);

                    //Envia dados para a tela principal
                    HomeScreen homeScreen = new HomeScreen(loadedUser.email, loadedUser.password);
                    homeScreen.Show();
                }
            }
        }
    }
}
