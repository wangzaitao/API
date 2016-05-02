namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class U_UserReg
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        public byte? IsWXUser { get; set; }

        public DateTime? LastLoginTime { get; set; }

        [StringLength(20)]
        public string LastLoginIP { get; set; }

        [StringLength(50)]
        public string LastLoginDevice { get; set; }
    }
}
