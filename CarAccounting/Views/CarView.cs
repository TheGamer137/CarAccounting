using System;
using System.Windows.Forms;
using CarAccounting.Presenters;
using CarAccounting.Views.Interfaces;

namespace CarAccounting.Views
{
    public partial class CarView : Form, ICarView
    {
        private static CarView _instance;
        public CarView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            buttonClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            searchButton.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            searchTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            addNewCarButton.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                if (ActiveForm != null) ActiveForm.Text = "Добавить машину";
            };
            editButton.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (ActiveForm != null) ActiveForm.Text = "Редактировать машину";
            };
            deleteButton.Click += delegate
            {
                var result = MessageBox.Show("Вы учерены что хотите удалить эту машину?", "Удаление машины", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string CarMark { get; set; }
        public string CarModel { get; set; }
        public string CarNumberPlate { get; set; }
        public string DateOfWork { get; set; }
        public string EngineType { get; set; }
        public string Services { get; set; }
        public string SearchValue
        {
            get { return searchTextBox.Text; }
            set { searchTextBox.Text = value; }
        }
        public bool IsEdit { get; set; }
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }

        
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;

        public void SetCarListBindingSource(BindingSource carList)
        {
            carsGridView.DataSource = carList;
        }

        /// <summary>
        /// Метод для отображения CarView внутри MainView
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns></returns>
        public static CarView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CarView();
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                {
                    _instance.WindowState = FormWindowState.Normal;
                }
                _instance.BringToFront();
            }
            return _instance;
        }
    }
}
