using System;
using System.Windows.Forms;
using CarAccounting._Repositories;
using CarAccounting.Presenters;
using CarAccounting.Views.Interfaces;

namespace CarAccounting.Views
{
    public partial class AddOrEditServicesView : Form, IAddOrEditServicesView, IMainView
    {
        public AddOrEditServicesView()
        {
            InitializeComponent();
            saveButton.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowCarsView?.Invoke(this, EventArgs.Empty);
                }
                MessageBox.Show(Message);
            };
            cancelButton.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ShowCarsView?.Invoke(this, EventArgs.Empty);
            };
        }

        
        
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }


        public event EventHandler ShowCarsView;
        public event EventHandler ShowServicesView;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public void SetAutocompleteBindingSource(BindingSource textBox)
        {
            throw new NotImplementedException();
        }
    }
}
