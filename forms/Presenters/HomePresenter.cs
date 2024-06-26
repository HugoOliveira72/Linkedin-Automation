using forms.Forms;
using forms.Models.Filters;
using forms.Models.Interfaces;
using forms.Repositories;
using forms.Services;
using forms.Views.Interfaces;

namespace forms.Presenters
{
    public class HomePresenter
    {
        private IHomeView _homeView;
        IDataService<dynamic> _dataService;
        //private IHomeRepository _homeRepository;

        public HomePresenter(IHomeView homeView, IDataService<dynamic> dataService)
        {
            _homeView = homeView;
            _dataService = dataService;
            //_homeView.ShowConfigView += ShowConfigurationView;
            //_homeView.ShowAutomationView += ShowAutomationView;
        }

        private void ShowConfigurationView(object sender, EventArgs e)
        {
            ConfigView configView = new ConfigView();
            IConfigRepository configRepository = new ConfigRepository();
            new ConfigPresenter(configView, configRepository);
            configView.Show();
        }

        private void ShowAutomationView(object sender, EventArgs e)
        {
            //_dataService.SetData(SetObject());
            ILogRepository logRepository = new LogRepository();
            ILogService logService = new LogService(logRepository);
            ILoginRepository loginRepository = new LoginRepository();

            AutomationView automationView = new AutomationView(_dataService);
            new AutomationPresenter(automationView, _dataService, logService, loginRepository, logRepository);
            automationView.Show();
        }

        //private FilterFieldsModel SetObject()
        //{
        //    FilterFieldsModel data = new FilterFieldsModel
        //    (
        //        _homeView.Job,
        //        Int32.Parse(_homeView.amountJobs),
        //        _homeView.ComboBoxClassifyBy,
        //        _homeView.comboBoxAnnoucementDate,
        //        _homeView.checkedListBoxExperienceLevel,
        //        _homeView.checkedListBoxTypeJob,
        //        _homeView.checkedListBoxRemote
        //    );
        //    return data;
        //}
    }
}
