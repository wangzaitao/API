namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class P_PdtParam
    {
        public long Id { get; set; }

        public long PdtID { get; set; }

        public long CategoryID { get; set; }

        public long ParamGroupID { get; set; }

        public long ParamID { get; set; }

        [StringLength(100)]
        public string ParamName { get; set; }

        [StringLength(200)]
        public string ParamValue { get; set; }

        public byte? IsShow { get; set; }

        public byte? OrderBy { get; set; }

        public byte? Flag { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }

        public byte? IsDelete { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
