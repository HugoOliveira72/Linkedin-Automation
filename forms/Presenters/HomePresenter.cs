using forms.Forms;
using forms.Models.Interfaces;
using forms.Repositories;
using forms.Views.Interfaces;

namespace forms.Presenters
{
    public class HomePresenter
    {
        private IHomeView _homeView;
        //private IHomeRepository _homeRepository;

        public HomePresenter (IHomeView homeView)
        {
            _homeView = homeView;
            _homeView.ShowConfigView += ShowConfigurationView;
            _homeView.ShowRunningView += ShowRunningView;
        }

        private void ShowConfigurationView(object sender, EventArgs e)
        {
            ConfigView configView = new ConfigView();
            IConfigRepository configRepository = new ConfigRepository();
            new ConfigPresenter(configView, configRepository);
            configView.Show();
        }

        private void ShowRunningView(object sender, EventArgs e)
        {

        }
    }
}
