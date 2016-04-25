namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class P_Param
    {
        public long ID { get; set; }

        public long PID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long? ShopID { get; set; }

        public long? ParamGroupID { get; set; }

        [StringLength(100)]
        public string AliasName { get; set; }

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
