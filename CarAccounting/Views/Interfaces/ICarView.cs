using System;
using System.Windows.Forms;

namespace CarAccounting.Views.Interfaces
{
    public interface ICarView
    {
        string CarMark { get; set; }
        string CarModel { get; set; }
        string CarNumberPlate { get; set; }
        string DateOfWork { get; set; }
        string Services { get; set; }
        string EngineType { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        //Ивенты
        
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;

        //Methods
        void SetCarListBindingSource(BindingSource bindingSource);
        void Show();
    }
}
