using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CarAccounting._Repositories;
using CarAccounting._Repositories.Cars;
using CarAccounting._Repositories.EngineTypes;
using CarAccounting.Models;
using CarAccounting.Views;
using CarAccounting.Views.Interfaces;

namespace CarAccounting.Presenters
{
    public class CarPresenter
    {
        private readonly ICarView _carView;
        private readonly ICarRepository _repository;
        private readonly IEngineTypeRepository _engineTypeRepository;
        private readonly BindingSource _carsBindingSource;
        private IEnumerable<Car> _carList;
        private IEnumerable<EngineType> _engineList;

        public CarPresenter(ICarView carView, ICarRepository repository, IEngineTypeRepository engineTypeRepository)
        {
            this._carsBindingSource = new BindingSource();
            this._carView = carView;
            this._engineTypeRepository = engineTypeRepository;
            this._repository = repository;
            this._carView.SearchEvent += SearchCar;
            this._carView.AddNewEvent += AddNewCar;
            this._carView.EditEvent += LoadSelectedCarToEdit;
            this._carView.DeleteEvent += DeleteSelectedCar;
            this._carView.SetCarListBindingSource(_carsBindingSource);
            LoadAllCarList();
            this._carView.Show();
        }

        private void LoadAllCarList()
        {
            _carList = _repository.GetAllCars();
            _carsBindingSource.DataSource = _carList;
        }

        private IEnumerable<EngineType> LoadAllEngines()
        {
            IEnumerable < EngineType > engineTypes = _engineTypeRepository.GetAllEngineTypes();
            _carsBindingSource.DataSource = engineTypes;
            return engineTypes;
        }
        

        private void SearchCar(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._carView.SearchValue);
            if (emptyValue == false)
                _carList = _repository.GetCarByValue(this._carView.SearchValue);
            else LoadAllCarList();
        }
        private void DeleteSelectedCar(object sender, EventArgs e)
        {
            try
            {
                var car = (Car)_carsBindingSource.Current;
                _repository.Delete(car.CarId);
                _carView.IsSuccessful = true;
                _carView.Message = "Машина успешно удалено";
                LoadAllCarList();
            }
            catch 
            {
                _carView.IsSuccessful = false;
                _carView.Message = "Возникла ошибка, не удалось удалить машину";
            }
        }
        //TODO: Не могу понять как нормально подгрузить в комбобокс и текстбокс
        private void LoadSelectedCarToEdit(object sender, EventArgs e)
        {
            _carView.IsEdit = true;
            var car = (Car)_carsBindingSource.Current;
            IAddOrEditCarView newCarView = new AddOrEditCarView();
            new AddOrEditCarPresenter(newCarView, _repository);
            newCarView.GetEngineType(LoadAllEngines());
            newCarView.CarMark = car.CarMark;
            newCarView.CarModel = car.CarModel;
            newCarView.CarNumberPlate = car.CarNumberPlate;
            newCarView.DateOfWork = car.DateOfWork;
            newCarView.EngineType = car.EngineId;
            newCarView.Services = car.ServicesId;
        }
        private void AddNewCar(object sender, EventArgs e)
        {
            _carView.IsEdit = false;
            IAddOrEditCarView newCarView = new AddOrEditCarView();
            new AddOrEditCarPresenter(newCarView, _repository);
            newCarView.GetEngineType(LoadAllEngines());

        }

    }
}
