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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampi_EFTravelDbEntities db = new EgitimKampi_EFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.tbl_Location.Count().ToString();
            lblSumCapacity.Text = db.tbl_Location.Sum(x => x.Capacity).ToString();
            lblSumGuide.Text = db.tbl_Guide.Count().ToString();
            // Burada yuvarlama işlemi yapıyoruz. 
            int? a = (int?) Math.Round(db.tbl_Location.Where(x => x.Capacity != null).Average(x => (double?)x.Capacity) ?? 0);
            lblAvgCapacity.Text = a.ToString();
            #region Direkt kontrol etmek istersek null olup olmadığını
            //var avarage = db.tbl_Location.Average(x => (double?)x.Capacity);
            //int z = avarage.HasValue ? (int) Math.Round(avarage.Value) : 0; // Ortalama değer null değil ise yuvarla noll ise 0 ver.
            #endregion

            lblAvgLocationPrice.Text = db.tbl_Location.Average(x => (decimal)x.Price).ToString("0.00")+ " ₺";

            // Eklenen Son Ülke 
            int lastCountryId = db.tbl_Location.Max(x=> x.LocationId);
            lblLastCountryName.Text = db.tbl_Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault(); // tek bir değer getirmek istediğim için firstordefault.

            // Kapadokyanın tur kapasitesi
            lblKapadokyaLocationCapactiy.Text = db.tbl_Location.Where(x=> x.City == "Kapadokya").Select(y=> y.Capacity).FirstOrDefault().ToString();

           // Türkiyede ki tüm turların toplam kapasitelerinin ortalaması
           // lblTürkiyeCapacityAvg.Text = db.tbl_Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
           // Yuvarlamak istiyorum üstteki işlemi çümkü 
            int? g =(int?) Math.Round(db.tbl_Location.Where(x => x.Country == "Türkiye").Where(y => y.Capacity != null).Average(z => (int?)z.Capacity) ?? 0);
            lblTürkiyeCapacityAvg.Text = g.ToString();

            // Roma şehrinin rehberinin isim soyismi
            int guideId = db.tbl_Location.Where(x=> x.City=="Roma").Select(y=> y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.tbl_Guide.Where(x=> x.GuideId==guideId)
                .Select(y=> y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            // En yüksek kapasiteli tur
            var maxCapacity= db.tbl_Location.Max(x=> x.Capacity);
            lblMaxCapacityLocation.Text = db.tbl_Location.Where(x=> x.Capacity==maxCapacity).Select(y=> y.City).FirstOrDefault().ToString();

            // En pahalı tur
            var maxPrice = db.tbl_Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.tbl_Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            // Ayşegül Çınar'ın tur sayısı
            var ayseGuideID = db.tbl_Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y=> y.GuideId).FirstOrDefault();
            lblAysegulCinarLOcationCount.Text= db.tbl_Location.Where(x=> x.GuideId==ayseGuideID).Count().ToString();

        }
    }
}
