using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarAccounting.Models;

namespace CarAccounting.Views.Interfaces
{
    public interface IAddOrEditCarView
    {
        string CarMark { get; set; }
        string CarModel { get; set; }
        string CarNumberPlate { get; set; }
        string DateOfWork { get; set; }
        string Services { get; set; }
        string EngineType { get; set; }
        string ServicesType { get; set; }
        bool IsEdit { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void GetEngineType(IEnumerable<EngineType> data);
        void Show();
    }
}
