using CSahrpEgitimKampi301_EntityLayer.Concrete;
using CSharpEgitimKampi_DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301_BusinnessLayer.Abstract;
using CSharpEgitimKampi301_BusinnessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301_PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryServices _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());  ;
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryAd.Text;
            category.CategoryStatus = radioButton1.Checked;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoyId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme işlemi başarılı!");
            

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoyId.Text);
            var getIdValues = _categoryService.TGetById(id);
            if (getIdValues != null)
            {
                dataGridView1.DataSource= new List<Category> {getIdValues};
            }
            else
            {
                MessageBox.Show("İşlem başarısız!");
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtCategoyId.Text);
            var updatedValues = _categoryService.TGetById(updatedId);
            updatedValues.CategoryName= txtCategoryAd.Text;
            updatedValues.CategoryStatus = radioButton1.Checked;
            _categoryService.TUpdate(updatedValues);
        }
    }
}
