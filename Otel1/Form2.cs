using OtelManager.DataAccess;
using OtelManager.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Otel1
{
    public partial class Form2 : Form
    {
        private readonly MainViewModel _viewModel;
        private Form1 loginForm = null;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form login)
        {
            loginForm = login as Form1;
            InitializeComponent();
            _viewModel = new MainViewModel(new OtelDataProvider());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _viewModel.Load();
            otelBindingSource.DataSource = _viewModel.Reservations;


            listBox1.DataSource = otelBindingSource;
            listBox1.DisplayMember = "ListItemRsv";

            cboRoom.DataSource = _viewModel.Rooms;
            cboRoom.DisplayMember = "RoomName";
            cboRoom.ValueMember = "Id";

            var areDataBindingsInitialized = cboRoom.DataBindings.Count > 0;
            if (areDataBindingsInitialized)
            {
                otelBindingSource.ResetBindings(false);
            }
            else
            {
                cboRoom.DataBindings.Add("SelectedValue", otelBindingSource, "RoomId");

                txtFirstName.DataBindings.Add("Text", otelBindingSource, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
                txtSurName.DataBindings.Add("Text", otelBindingSource, "SurName", false, DataSourceUpdateMode.OnPropertyChanged);
                txtPhoneNumber.DataBindings.Add("Text", otelBindingSource, "PhoneNumber", false, DataSourceUpdateMode.OnPropertyChanged);

                dtCheckInDate.DataBindings.Add("Value", otelBindingSource, "CheckInDateTime");
                dtCheckOutDate.DataBindings.Add("Value", otelBindingSource, "CheckOutDateTime");
                txtAdultCount.DataBindings.Add("Text", otelBindingSource, "AdultCount", false, DataSourceUpdateMode.OnPropertyChanged);
                txtChildCount.DataBindings.Add("Text", otelBindingSource, "ChildCount", false, DataSourceUpdateMode.OnPropertyChanged);

                cbIsBreakfast.DataBindings.Add("Checked", otelBindingSource,"IsBreakfast");
                cbIsDinner.DataBindings.Add("Checked", otelBindingSource, "IsDinner");

                //dtCheckInDate

                //dtpEntryDate.DataBindings.Add("Value", otelBindingSource, "EntryDateTime");
                //chkIsCoffeeDrinker.DataBindings.Add("
                //Checked", otelBindingSource,"IsCoffeeDrinker");

                //btnSave.DataBindings.Add("Enabled", otelBindingSource, "CanSave");
            }

        }

        private void exit(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("message");
            string theDate = DateTime.Now.ToString("h:mm:ss tt");
            this.loginForm.label4.Text = (theDate+" "+"Last Save");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
