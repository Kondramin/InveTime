using InveTime.DataBase.DLL.Entityes.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace InveTime.DataBase.DLL.Entityes
{
    public class Product : NamedEntity
    {
        public string Barcode { get; set; }
        public string VendorCode { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal? Cost { get; set; }
        public int AmountData { get; set; }
        public int AmountFact { get; set; }



        public int AmountResult { get; set; }
        public bool Peresort { get; set; } = false;



        public int? CategoryId { get; set; }
        public Category Category { get; set; }



        public int? DateInventarisationId { get; set; }
        public DateInventarisation DateInventarisation { get; set; }
    }
}
