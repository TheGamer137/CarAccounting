using System;
using System.Windows.Forms;
using CarAccounting.Views.Interfaces;

namespace CarAccounting.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            buttonCars.Click += delegate { ShowCarsView?.Invoke(this, EventArgs.Empty); };
            buttonServices.Click += delegate { ShowServicesView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowCarsView;
        public event EventHandler ShowServicesView;
    }
}
