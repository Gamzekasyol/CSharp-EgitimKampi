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
    public partial class FrmProduct : Form
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryServices _categoryServices;
        public FrmProduct()
        {
            _productServices = new ProductManager(new EfProductDal());
            _categoryServices= new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryServices.TGetAll();
            comboBoxCategory.DataSource = values;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
        }
       
        private void btnList_Click(object sender, EventArgs e)
        {
            var listValues = _productServices.TGetAll();
            dataGridView1.DataSource = listValues;
           
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            // category tablosu ile product tablosu bağlı olduğu için listelediğimizde category adında bir sütun geliyor. Bunun olmaması için DataAccess Layer ->IProductDal sınıfında özel bir metot tanımlayacağız. Bu metodu EfProductDal sınıfında dolduracağız.
            var values = _productServices.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deletedValues = _productServices.TGetById(id);
            _productServices.TDelete(deletedValues);
            MessageBox.Show("Ürün silme işlemi gerçekleştirildi!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(comboBoxCategory.SelectedValue.ToString());
            product.ProductName = txtUrunAd.Text;
            product.ProductPrice = decimal.Parse(txtUrunPrıce.Text);
            product.ProductStock = int.Parse(txtUrunStok.Text);
            product.ProductDescription = txtUrunDescription.Text;
            _productServices.TInsert(product);
            MessageBox.Show("Ürün ekleme işlemi gerçekleştirildi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var idValues = _productServices.TGetById(id);
            idValues.ProductName = txtUrunAd.Text;
            idValues.ProductDescription = txtUrunDescription.Text;
            idValues.ProductPrice = int.Parse(txtUrunPrıce.Text);
            idValues.ProductStock = int.Parse(txtUrunStok.Text);
            idValues.CategoryId = int.Parse(comboBoxCategory.SelectedValue.ToString());
            _productServices.TUpdate(idValues);
            MessageBox.Show("Ürün güncelleme işlemi gerçekleştirildi!");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var idValues = _productServices.TGetById(id);
            if (idValues != null)
            {
                dataGridView1.DataSource = new List<Product>{idValues};
                MessageBox.Show("İşlem başarılı!");
            }
            else
            {
                MessageBox.Show("İşlem başarısız!");
            }
        }
    }
}
