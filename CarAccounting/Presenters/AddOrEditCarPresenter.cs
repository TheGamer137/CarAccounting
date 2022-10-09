using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarAccounting._Repositories;
using CarAccounting._Repositories.Cars;
using CarAccounting._Repositories.EngineTypes;
using CarAccounting.Models;
using CarAccounting.Views;
using CarAccounting.Views.Interfaces;

namespace CarAccounting.Presenters
{
    public class AddOrEditCarPresenter
    {
        private readonly ICarRepository _repository;
        private readonly IAddOrEditCarView _addOrEditCarView;
        public AddOrEditCarPresenter(IAddOrEditCarView view, ICarRepository repository)
        {
            this._addOrEditCarView = view;
            this._repository = repository;
            this._addOrEditCarView.SaveEvent += SaveEvent;
            this._addOrEditCarView.CancelEvent += CancelEvent;
            this._addOrEditCarView.Show();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        //TODO: Доработать редактирование и добавление
        private void SaveEvent(object sender, EventArgs e)
        {
            var car = new Car();
            car.CarModel = _addOrEditCarView.CarModel;
            car.CarMark = _addOrEditCarView.CarMark;
            car.CarNumberPlate = _addOrEditCarView.CarNumberPlate;
            car.DateOfWork = _addOrEditCarView.DateOfWork;
            car.EngineId = _addOrEditCarView.EngineType;
            car.ServicesId = _addOrEditCarView.Services;
            try
            {
                new Common.ModelDataValidation().Validate(car);
                if (_addOrEditCarView.IsEdit) //Редактирование
                {
                    _repository.Edit(car);
                    _addOrEditCarView.Message = "Редактирование завершено";
                }
                else //Добавление
                {
                    _repository.Add(car);
                    _addOrEditCarView.Message = "Машина добавлена";
                }

                _addOrEditCarView.IsSuccessful = true;
                CleanviewFields();
            }
            catch (Exception ex)
            {
                _addOrEditCarView.IsSuccessful = false;
                _addOrEditCarView.Message = ex.Message;
            }
        }
        private void CleanviewFields()
        {
            
            _addOrEditCarView.CarModel = "";
            _addOrEditCarView.CarMark = "";
            _addOrEditCarView.CarNumberPlate = "";
            _addOrEditCarView.DateOfWork = "";
            _addOrEditCarView.EngineType = "";
            _addOrEditCarView.Services = "";
        }
    }
}
