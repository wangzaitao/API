using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    [Serializable]
    public class TripListEntity
    {
        public int? isjian { get; set; }
        public int? istejia { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string kindlist { get; set; }
        public string attrid { get; set; }
        public long? lineday { get; set; }
        public int? storeprice { get; set; }
        public string litpic { get; set; }
        public long? modtime { get; set; }
    }
}
