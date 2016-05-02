namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class S_Employee
    {
        public long ID { get; set; }

        public long AdminID { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public byte? Sex { get; set; }

        [StringLength(20)]
        public string Birth { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [StringLength(100)]
        public string Dept { get; set; }

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
        public string Address { get; set; }

        [StringLength(100)]
        public string HeadImage { get; set; }

        [Column(TypeName = "text")]
        public string Introduces { get; set; }

        public byte? IsDelete { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
