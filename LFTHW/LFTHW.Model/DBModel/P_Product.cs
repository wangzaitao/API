namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class P_Product
    {
        public long ID { get; set; }

        public long TypeID { get; set; }

        public long BrandID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public long? ShopID { get; set; }

        [StringLength(100)]
        public string PdtNo { get; set; }

        [StringLength(1000)]
        public string PriceExplain { get; set; }

        public byte? PriceType { get; set; }

        public decimal? EnfantPrice { get; set; }

        public decimal? ListingPrice { get; set; }

        public decimal? RetailPrice { get; set; }

        public decimal? MemberPrice { get; set; }

        public decimal? YouHuiPrice { get; set; }

        [StringLength(1000)]
        public string DiscountDetail { get; set; }

        public decimal? IntegralCoefficient { get; set; }

        public decimal? DiscountCoefficient { get; set; }

        public int? Stock { get; set; }

        public int? BuyMax { get; set; }

        public int? BuyMin { get; set; }

        public int? IsCanOrder { get; set; }

        [StringLength(20)]
        public string LinkTel { get; set; }

        [StringLength(1000)]
        public string PdtBrief { get; set; }

        [Column(TypeName = "text")]
        public string PdtDetail { get; set; }

        public byte? IsTrip { get; set; }

        public int? ProvinceID { get; set; }

        public int? CityID { get; set; }

        public int? DistrictID { get; set; }

        [StringLength(100)]
        public string PdtImgUrl { get; set; }

        public int? VisitNum { get; set; }

        public int? CommentNum { get; set; }

        public int? SelledNum { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Meta_Keywords { get; set; }

        [StringLength(1000)]
        public string Meta_Description { get; set; }

        public byte? IsPolicy { get; set; }

        public byte? IsTop { get; set; }

        public byte? IsCommend { get; set; }

        public byte? IsShow { get; set; }

        public byte? Flag { get; set; }

        public byte? IsEnable { get; set; }

        public byte? IsDelete { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
