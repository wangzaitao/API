using System.Collections.Generic;

namespace LFTHW.Model
{
    public class TreeObject
    {
        public long id { get; set; }
        public string text { get; set; }
        public List<TreeObject> nodes { get; set; }
        public string flag { get; set; }
    }
}
