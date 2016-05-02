namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class P_PdtInfo
    {
        public long ID { get; set; }

        public long PdtID { get; set; }

        public int? PdtType { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public string TrafficeInfo { get; set; }

        [Column(TypeName = "text")]
        public string BookNotice { get; set; }

        [Column(TypeName = "text")]
        public string FriendlyPrompt { get; set; }

        [Column(TypeName = "text")]
        public string RouteFeature { get; set; }

        public long? Trip_Type { get; set; }

        public long? Trip_JoinType { get; set; }

        public int? Trip_SignUpAheadDays { get; set; }

        public int? Trip_Days { get; set; }

        public byte? Trip_RouteType { get; set; }

        [StringLength(20)]
        public string Trip_StartCity { get; set; }

        public DateTime? Trip_StartDate { get; set; }

        public byte? Trip_StartType { get; set; }

        public int? Trip_GoTrafficType { get; set; }

        public int? Trip_ReturnTrafficType { get; set; }

        public int? Trip_TrafficType { get; set; }

        [StringLength(200)]
        public string Trip_TrafficContent { get; set; }

        public int? Hotel_Level { get; set; }

        public string Hotel_Services { get; set; }

        public int? Sight_Type { get; set; }

        public int? Cars_HiresType { get; set; }

        public int? Cars_Type { get; set; }

        public int? Cars_PersonNum { get; set; }

        [StringLength(100)]
        public string Cars_Config { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
