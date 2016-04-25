namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class U_UserInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ParentID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string NickName { get; set; }

        public byte? Sex { get; set; }

        [StringLength(20)]
        public string Birth { get; set; }

        public long? ProvinceID { get; set; }

        public long? CityID { get; set; }

        public long? DistrictID { get; set; }

        [StringLength(20)]
        public string Telephone { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string QQ { get; set; }

        [StringLength(100)]
        public string HeadImage { get; set; }

        public int? UserType { get; set; }

        public int? UserLevel { get; set; }

        [Column(TypeName = "text")]
        public string Introduce { get; set; }

        public byte? IsFX { get; set; }

        public byte? IsShowNickName { get; set; }

        public byte? IsEnable { get; set; }

        public byte? IsDelete { get; set; }

        public DateTime? CreatTime { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
