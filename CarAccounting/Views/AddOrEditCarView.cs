using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarAccounting._Repositories;
using CarAccounting.Models;
using CarAccounting.Presenters;
using CarAccounting.Views.Interfaces;

namespace CarAccounting.Views
{
    public partial class AddOrEditCarView : Form, IAddOrEditCarView, IMainView
    {

        public AddOrEditCarView()
        {
            InitializeComponent();
            saveButton.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ActiveForm.Close();
                }
                MessageBox.Show(Message);
            };
            cancelButton.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ActiveForm.Close();
                ShowCarsView?.Invoke(this, EventArgs.Empty);
            };
        }
        

        public string CarMark
        {
            get => carModelTextBox.Text;
            set => carModelTextBox.Text = value;
        }

        public string CarModel
        {
            get => textBoxCarMark.Text;
            set => textBoxCarMark.Text = value;
        }

        public string CarNumberPlate
        {
            get => textBoxNumberPlate.Text;
            set => textBoxNumberPlate.Text = value;
        }

        public string DateOfWork
        {
            get => textBoxDateOfWork.Text;
            set => textBoxDateOfWork.Text = value;
        }

        public string Services
        {
            get => textBoxServices.Text;
            set => textBoxServices.Text = value;
        }

        public string EngineType
        {
            get => comboBoxEngineType.Text;
            set => comboBoxEngineType.Text = value;
        }

        public string ServicesType
        {
            get => textBoxServices.Text;
            set => textBoxServices.Text = value;
        }

        public bool IsEdit { get; set; }

        public string Message { get; set; }
        public bool IsSuccessful { get; set; }


        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void GetEngineType(IEnumerable<EngineType> data)
        {
            comboBoxEngineType.DataSource = data;
            comboBoxEngineType.ValueMember = "EngineId";
            comboBoxEngineType.DisplayMember = "EngineName";
            
        }

        public event EventHandler ShowCarsView;
        public event EventHandler ShowServicesView;
    }
}
