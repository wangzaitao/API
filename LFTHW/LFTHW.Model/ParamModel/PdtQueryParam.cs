using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFTHW.Model
{
    public class PdtQueryParam : PageQueryParam
    {//产品关键字、产品名称、是否显示、是否可预定
        public long TypeID { get; set; }
        public long CategoryID { get; set; }
        public long BrandID { get; set; }
        public string Keyword { get; set; }
        public string PdtName { get; set; }
        public byte? IsShow { get; set; }
        public byte? IsCanOrder { get; set; }
    }
}
