using forms.Models;
using forms.Views.Interfaces;
using Linkedin_Automation.Model;
using MessagePack;
using Newtonsoft.Json;

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
            _loginRepository = loginRepository;
            _loginView = loginView;
            _loginView.UserFormLoaded += OnUserFormLoaded;
            _loginView.LoginEvent += LoginEvent;
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    // Cria o arquivo se não existir
                    User newUser = new User(_loginView.Email, _loginView.Password);
                    _loginRepository.create(filePath);
                    _loginRepository.edit(filePath, newUser);
                }
                else
                {
                    //Carrega usuário do arquivo
                    User loadedUser = LoadUser();

                    if (_loginView.Email != null && _loginView.Password != null)
                    {
                        // Atualiza o usuário com novos dados
                        var updatedUser = new User(_loginView.Email, _loginView.Password);
                        _loginRepository.edit(filePath, updatedUser);
                    }
                    else
                    {
                        // Mantém o usuário existente
                        _loginRepository.edit(filePath, loadedUser);
                    }

                    // Envia dados para a tela principal
                    HomeScreen homeScreen = new HomeScreen(loadedUser.email, loadedUser.password);
                    homeScreen.Show();

                }
            }
            catch (FileNotFoundException fileException)
            {
                Console.WriteLine("Arquivo não encontrado.", fileException);
            }
            catch (JsonException jsonException)
            {
                Console.WriteLine("Erro ao desserializar JSON.", jsonException);
            }
        }

        private void OnUserFormLoaded(object sender, EventArgs e)
        {
            User user = LoadUser();
           
            if (user.email != "" || user.password != "")
            {
                _loginView.Email = user.email;
                _loginView.Password = user.password;
            }
        }

        private User LoadUser()
        {
            byte[] fileBytes = _loginRepository.read(filePath);

            // Desserializa os bytes em um objeto User
            var loadedUserJson = MessagePackSerializer.Deserialize<dynamic>(fileBytes);
            return JsonConvert.DeserializeObject<User>(loadedUserJson);
        }
    }

}
