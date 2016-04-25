namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class P_Route
    {
        public long ID { get; set; }

        public long PdtID { get; set; }

        public byte? RouteType { get; set; }

        [StringLength(200)]
        public string DayTitle { get; set; }

        [Column(TypeName = "text")]
        public string DayContent { get; set; }

        [StringLength(100)]
        public string DayEat { get; set; }

        [StringLength(100)]
        public string DayHotel { get; set; }

        public byte? DayOrderBy { get; set; }

        [Column(TypeName = "text")]
        public string ShowDetailContent { get; set; }

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
