namespace LFTHW.Model
{
    using System;
    

    public partial class P_PdtKeyword
    {
        public long Id { get; set; }

        public long PdtID { get; set; }

        public long Keyword { get; set; }

        public byte? IsShow { get; set; }

        public byte? OrderBy { get; set; }

        public byte? IsDelete { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
