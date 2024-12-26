using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpEgitimKampi301_501.Dtos
{
    public class ResultProductDto
    {
        public int ProductId {  get; set; }
        public string ProductName {  get; set; }
        public int ProductStok {  get; set; }
        public string ProductCategory {  get; set; }
        public decimal ProductPrice {  get; set; }
    }
}
