using forms.Forms;
using forms.Models.Interfaces;
using forms.Repositories;
using forms.Views.Interfaces;
using Linkedin_Automation.Model;
using Linkedin_Automation.Utilities;
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

        //Attr
        LogUtilities logUtilities = new LogUtilities();

        public LoginPresenter(ILoginView loginView, ILoginRepository loginRepository)
        {
            _loginRepository = (ILoginRepository?)loginRepository;
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
                    UserModel newUser = new UserModel(_loginView.Email, _loginView.Password);
                    _loginRepository.create(filePath);
                    _loginRepository.update(filePath, newUser);
                }
                else
                {
                    if (_loginView.Email != null && _loginView.Password != null)
                    {
                        // Atualiza o usuário com novos dados
                        var updatedUser = new UserModel(_loginView.Email, _loginView.Password);
                        _loginRepository.update(filePath, updatedUser);
                    }

                    //Carrega usuário do arquivo
                    UserModel loadedUser = _loginRepository.LoadConvertedObject<UserModel>(filePath);
                }
            }
            catch (FileNotFoundException fileException)
            {
                logUtilities.LogError("Arquivo não encontrado.", fileException);
            }
            catch (JsonException jsonException)
            {
                logUtilities.LogError("Erro ao desserializar JSON.", jsonException);
            }
        }

        private void OnUserFormLoaded(object sender, EventArgs e)
        {
            UserModel user = _loginRepository.LoadConvertedObject<UserModel>(filePath);

            if (user.email != "" || user.password != "")
            {
                _loginView.Email = user.email;
                _loginView.Password = user.password;
            }
        }

        private UserModel LoadUser()
        {
            byte[] fileBytes = _loginRepository.read(filePath);

            // Desserializa os bytes em um objeto User
            var loadedUserJson = MessagePackSerializer.Deserialize<dynamic>(fileBytes);
            return JsonConvert.DeserializeObject<UserModel>(loadedUserJson);
        }
    }

}
