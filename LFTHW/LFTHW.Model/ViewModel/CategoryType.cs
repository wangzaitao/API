using System.ComponentModel.DataAnnotations.Schema;

namespace LFTHW.Model
{
    [NotMapped]
    public class CategoryType : P_Category
    {
        public long TypeID { get; set; }
    }
}
