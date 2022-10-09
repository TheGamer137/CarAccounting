using System;

namespace CarAccounting.Views.Interfaces
{
    public interface IMainView
    {
        event EventHandler ShowCarsView;
        event EventHandler ShowServicesView;
    }
}
