using forms.Model;
using forms.Models.Interfaces;
using forms.Views.Interfaces.Control;

namespace forms.Presenters
{
    public class ConfigPresenter
    {
        private IConfigControlView _configView;
        private IConfigRepository _configRepository;
        private string _filePath;

        public ConfigPresenter(IConfigControlView configView, IConfigRepository configRepository)
        {
            _configView = configView;
            _configRepository = configRepository;

            _configView.SaveConfigEvent += SaveConfigEvent;
            _configView.ConfigFormLoaded += OnConfigFormLoaded;
            _filePath = configRepository.GetConfigFilePath();

        }

        private void SaveConfigEvent(object sender, EventArgs e)
        {
            // Cria uma nova configuração de tela com os valores selecionados nos ComboBoxes
            ConfigurationModel configModel = new ConfigurationModel(_configView.ResolutionType, _configView.Resolution);

            // Abre o arquivo especificado para gravação
            _configRepository.UpdateMessagePackFile(_filePath, configModel);
        }

        private void OnConfigFormLoaded(object sender, EventArgs e)
        {
            // Verifica se o arquivo resolution existe
            if (!File.Exists(_filePath)) // Quando o arquivo Resolution não existe
            {
                // Cria um novo arquivo e escreve "Tela cheia" como padrão
                ConfigurationModel configurationModel = new ConfigurationModel("Tela cheia", "");
                _configRepository.CreateMessagePackFile(_filePath);
                _configRepository.UpdateMessagePackFile(_filePath, configurationModel);
                _configView.ResolutionTypeSelectedIndex = 0;
            }
            else // Quando o arquivo Resolution existe
            {
                ConfigurationModel configModel = _configRepository.ReadAndConvertMessagepackFileToObject<ConfigurationModel>(_filePath);

                // Atribui o primeiro item da lista (que é a primeira linha do arquivo) ao Text do comboBox_resolution_type
                _configView.ResolutionType = configModel.ScreenType;

                // Atribui o último item da lista (que é a última linha do arquivo) ao Text do comboBox_resolution
                _configView.Resolution = configModel.Resolution;
            }
        }
    }
}
