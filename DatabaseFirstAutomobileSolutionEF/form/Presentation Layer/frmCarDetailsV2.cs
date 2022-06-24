using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibraryDatabaseFirst.Models;
namespace AutomobileWinAppDBFirst
{
    public partial class frmCarDetailsV2 : Form
    {
        public frmCarDetailsV2()
        {
            InitializeComponent();
        }

        public MyStockEFContext CarRepository { get; set; }

        public bool InsertOrUpdate { get; set; }

        public Car CarInfo { get; set; }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) // update mode
            {
                //Show car to perform updating
                txtCarID.Text = CarInfo.CarId.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarId = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text),
                };
                if (InsertOrUpdate == false)
                {
                    CarRepository.Add(car);
                    CarRepository.SaveChanges();
                    
                }
                else
                {
                    CarRepository.UpdateRange(car);
                    CarRepository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
