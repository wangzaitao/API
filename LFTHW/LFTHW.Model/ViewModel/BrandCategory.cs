using System.ComponentModel.DataAnnotations.Schema;

namespace LFTHW.Model
{
    [NotMapped]
    public class BrandCategory : P_Brand
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
