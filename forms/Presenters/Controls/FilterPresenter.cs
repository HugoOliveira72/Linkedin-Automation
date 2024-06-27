using forms.Models.Filters;
using forms.Services;
using forms.Views.Interfaces.Control;

namespace forms.Presenters.Controls
{
    public class FilterPresenter
    {
        public IFilterControlView _filterControlView;
        public IDataService<dynamic> _dataService;
        public FilterPresenter(IFilterControlView filterControlView, IDataService<dynamic> dataService)
        {
            _filterControlView = filterControlView;
            _filterControlView.HandleFilter += HandleFilters;
            _dataService = dataService;
        }

        private void HandleFilters(object sender, EventArgs e)
        {
            _dataService.SetData(SetObject());
        }

        private FilterFieldsModel SetObject()
        {
            FilterFieldsModel data = new FilterFieldsModel
            (
                _filterControlView.ComboBoxClassifyBy,
                _filterControlView.comboBoxAnnoucementDate,
                _filterControlView.checkedListBoxExperienceLevel,
                _filterControlView.checkedListBoxTypeJob,
                _filterControlView.checkedListBoxRemote
            );
            return data;
        }
    }
}
