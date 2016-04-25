namespace LFTHW.Model
{
    using System.ComponentModel.DataAnnotations;
    

    public partial class U_UserAddress
    {
        public long ID { get; set; }

        public long UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string ProvinceID { get; set; }

        [StringLength(100)]
        public string CityID { get; set; }

        [StringLength(100)]
        public string DistrictID { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public byte? IsDefault { get; set; }
    }
}
