using System.ComponentModel.DataAnnotations.Schema;

namespace LFTHW.Model
{
    [NotMapped]
    public class CategoryProduct: P_Product
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string TypeName { get; set; }
        public string BrandName { get; set; }
        public string KeywordName { get; set; }
    }
}
