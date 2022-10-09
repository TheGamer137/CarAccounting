using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarAccounting._Repositories;
using CarAccounting._Repositories.Cars;
using CarAccounting._Repositories.EngineTypes;
using CarAccounting.Views;
using CarAccounting.Views.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarAccounting.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;
        private readonly string _sqlConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this._mainView = mainView;
            this._sqlConnectionString = sqlConnectionString;
            this._mainView.ShowCarsView += ShowCarsView;
            this._mainView.ShowServicesView += ShowServicesView;
        }

        private void ShowServicesView(object sender, EventArgs e)
        {
            //TODO: Добавить добавление и редакцию услуг по виду двигателя
        }

        private void ShowCarsView(object sender, EventArgs e)
        {
            ICarView view = CarView.GetInstance((MainView)_mainView);
            ICarRepository repository = new CarRepository(_sqlConnectionString);
            IEngineTypeRepository engineTypeRepository = new EngineTypeRepository(_sqlConnectionString);
            new CarPresenter(view, repository, engineTypeRepository);
        }
    }
}
