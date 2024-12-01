using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301_EntityFramework_Project
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampi_EFTravelDbEntities db = new EgitimKampi_EFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.tbl_Location.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            // Combobox'a değerleri getirme.
            var Values = db.tbl_Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname, 
                x.GuideId
            }).ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "GuideId";
            comboBox1.DataSource = Values;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl_Location location = new tbl_Location();
           
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Capacity = byte.Parse(numericUpDown1.Value.ToString());// byte'a çevirdik çünkü veri tanındaki tipi tiny 
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(comboBox1.SelectedValue.ToString());
            db.tbl_Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deletedValue = db.tbl_Location.Find(id);
            db.tbl_Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var updateValue = db.tbl_Location.Find(id);
            updateValue.City = txtCity.Text;
            updateValue.Country = txtCountry.Text;
            updateValue.Capacity= byte.Parse(numericUpDown1.Value.ToString());
            updateValue.Price = decimal.Parse(txtPrice.Text);
            updateValue.DayNight= txtDayNight.Text;
            updateValue.GuideId = int.Parse(comboBox1.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı!");
        }
    }
}
