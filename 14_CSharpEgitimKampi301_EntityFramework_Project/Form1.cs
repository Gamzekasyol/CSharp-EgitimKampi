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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Öncelikle modele ulaşıyoruz. 
        EgitimKampi_EFTravelDbEntities db = new EgitimKampi_EFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
           

            var values = db.tbl_Guide.ToList();
            dataGridView1.DataSource = values;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            // ekleme işlemini guide tablosuna yapacağız.
            tbl_Guide guide = new tbl_Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.tbl_Guide.Add(guide);

            db.SaveChanges(); // değişiklikleri veri tabanına kaydetmek için
            MessageBox.Show("Rehber başarıyla eklendi.");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse( txtid.Text);
            // Find: id'ye göre bulmamızı sağlar.
            var removeValue = db.tbl_Guide.Find(id);
            db.tbl_Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var updateValue = db.tbl_Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int. Parse(txtid.Text);
            // x öyleki, GuidId'si bizim gönderdiğim id ile eşit olanları listele
            var values = db.tbl_Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
