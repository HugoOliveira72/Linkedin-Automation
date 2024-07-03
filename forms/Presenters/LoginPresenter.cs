using forms.Models.Interfaces;
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
        ILogRepository _logRepository;
        private string _filePath;

        //Attr

        public LoginPresenter(ILoginView loginView, ILoginRepository loginRepository, ILogRepository logRepository)
        {
            _loginRepository = (ILoginRepository?)loginRepository;
            _loginView = loginView;
            _loginView.UserFormLoaded += OnUserFormLoaded;
            _loginView.LoginEvent += LoginEvent;
            _filePath = loginRepository.GetFilePath();
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    // Cria o arquivo se não existir
                    UserModel newUser = new UserModel(_loginView.Email, _loginView.Password);
                    _loginRepository.CreateMessagePackFile(_filePath);
                    _loginRepository.UpdateMessagePackFile(_filePath, newUser);
                }
                else
                {
                    if (_loginView.Email != null && _loginView.Password != null)
                    {
                        // Atualiza o usuário com novos dados
                        var updatedUser = new UserModel(_loginView.Email, _loginView.Password);
                        _loginRepository.UpdateMessagePackFile(_filePath, updatedUser);
                    }

                    //Carrega usuário do arquivo
                    UserModel loadedUser = _loginRepository.ReadAndConvertMsgpackFileToObject();
                }
            }
            catch (FileNotFoundException fileException)
            {
                _logRepository.WriteALogError("Arquivo não encontrado.", fileException);
            }
            catch (JsonException jsonException)
            {
                _logRepository.WriteALogError("Erro ao desserializar JSON.", jsonException);
            }
        }

        private void OnUserFormLoaded(object sender, EventArgs e)
        {
            UserModel user = _loginRepository.ReadAndConvertMsgpackFileToObject();

            if (user.email != "" || user.password != "")
            {
                _loginView.Email = user.email;
                _loginView.Password = user.password;
            }
        }

        private UserModel LoadUser()
        {
            byte[] fileBytes = _loginRepository.ReadMessagePackFile(_filePath);

            // Desserializa os bytes em um objeto User
            var loadedUserJson = MessagePackSerializer.Deserialize<dynamic>(fileBytes);
            return JsonConvert.DeserializeObject<UserModel>(loadedUserJson);
        }
    }

}
