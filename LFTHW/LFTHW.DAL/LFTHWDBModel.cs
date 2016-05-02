namespace LFTHW.DAL
{
    using System.Data.Entity;
    using LFTHW.Model;

    public partial class LFTHWDBModel : DbContext
    {
        public LFTHWDBModel()
            : base("name=LFTHWDBModel")
        {
        }

        public virtual DbSet<P_Brand> P_Brand { get; set; }
        public virtual DbSet<P_Category> P_Category { get; set; }
        public virtual DbSet<P_CategoryBrand> P_CategoryBrand { get; set; }
        public virtual DbSet<P_CategoryParamGroup> P_CategoryParamGroup { get; set; }
        public virtual DbSet<P_CategoryProduct> P_CategoryProduct { get; set; }
        public virtual DbSet<P_Param> P_Param { get; set; }
        public virtual DbSet<P_ParamGroup> P_ParamGroup { get; set; }
        public virtual DbSet<P_PdtInfo> P_PdtInfo { get; set; }
        public virtual DbSet<P_PdtKeyword> P_PdtKeyword { get; set; }
        public virtual DbSet<P_PdtParam> P_PdtParam { get; set; }
        public virtual DbSet<P_Picture> P_Picture { get; set; }
        public virtual DbSet<P_Price> P_Price { get; set; }
        public virtual DbSet<P_Product> P_Product { get; set; }
        public virtual DbSet<P_Route> P_Route { get; set; }
        public virtual DbSet<P_Type> P_Type { get; set; }
        public virtual DbSet<P_TypeCategory> P_TypeCategory { get; set; }
        public virtual DbSet<S_Admin> S_Admin { get; set; }
        public virtual DbSet<S_City> S_City { get; set; }
        public virtual DbSet<S_District> S_District { get; set; }
        public virtual DbSet<S_Employee> S_Employee { get; set; }
        public virtual DbSet<S_FriendLink> S_FriendLink { get; set; }
        public virtual DbSet<S_FXCommision> S_FXCommision { get; set; }
        public virtual DbSet<S_Notice> S_Notice { get; set; }
        public virtual DbSet<S_Province> S_Province { get; set; }
        public virtual DbSet<U_UserAddress> U_UserAddress { get; set; }
        public virtual DbSet<U_UserReg> U_UserReg { get; set; }
        public virtual DbSet<UP_Cart> UP_Cart { get; set; }
        public virtual DbSet<UP_CommentImage> UP_CommentImage { get; set; }
        public virtual DbSet<UP_CommentReply> UP_CommentReply { get; set; }
        public virtual DbSet<UP_Order> UP_Order { get; set; }
        public virtual DbSet<UP_OrderDetail> UP_OrderDetail { get; set; }
        public virtual DbSet<UP_UserComment> UP_UserComment { get; set; }
        public virtual DbSet<UP_UserConsume> UP_UserConsume { get; set; }
        public virtual DbSet<U_UserAccount> U_UserAccount { get; set; }
        public virtual DbSet<U_UserInfo> U_UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<P_Brand>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<P_Category>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<P_Param>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<P_ParamGroup>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<P_PdtInfo>()
                .Property(e => e.BookNotice)
                .IsUnicode(false);

            modelBuilder.Entity<P_PdtInfo>()
                .Property(e => e.FriendlyPrompt)
                .IsUnicode(false);

            modelBuilder.Entity<P_PdtInfo>()
                .Property(e => e.RouteFeature)
                .IsUnicode(false);

            modelBuilder.Entity<P_PdtParam>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<P_Picture>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<P_Price>()
                .Property(e => e.MenShiPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Price>()
                .Property(e => e.YouHuiPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Price>()
                .Property(e => e.ErTongPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Price>()
                .Property(e => e.HuiYuanPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Price>()
                .Property(e => e.TongHangPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Price>()
                .Property(e => e.PriceIntroduces)
                .IsUnicode(false);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.EnfantPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.ListingPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.RetailPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.MemberPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.YouHuiPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.IntegralCoefficient)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.DiscountCoefficient)
                .HasPrecision(18, 0);

            modelBuilder.Entity<P_Product>()
                .Property(e => e.PdtDetail)
                .IsUnicode(false);

            modelBuilder.Entity<P_Route>()
                .Property(e => e.DayContent)
                .IsUnicode(false);

            modelBuilder.Entity<P_Route>()
                .Property(e => e.ShowDetailContent)
                .IsUnicode(false);

            modelBuilder.Entity<P_Route>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<P_Type>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<S_City>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<S_District>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<S_Employee>()
                .Property(e => e.Introduces)
                .IsUnicode(false);

            modelBuilder.Entity<S_FriendLink>()
                .Property(e => e.Introduces)
                .IsUnicode(false);

            modelBuilder.Entity<S_FXCommision>()
                .Property(e => e.First)
                .HasPrecision(18, 0);

            modelBuilder.Entity<S_FXCommision>()
                .Property(e => e.Second)
                .HasPrecision(18, 0);

            modelBuilder.Entity<S_FXCommision>()
                .Property(e => e.Third)
                .HasPrecision(18, 0);

            modelBuilder.Entity<S_FXCommision>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<S_Notice>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<S_Province>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<UP_Cart>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_Cart>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_CommentReply>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<UP_Order>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_Order>()
                .Property(e => e.Freight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_Order>()
                .Property(e => e.PMoney)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_Order>()
                .Property(e => e.ConsumerRemark)
                .IsUnicode(false);

            modelBuilder.Entity<UP_Order>()
                .Property(e => e.CancelRemark)
                .IsUnicode(false);

            modelBuilder.Entity<UP_OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_OrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_OrderDetail>()
                .Property(e => e.Discount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_OrderDetail>()
                .Property(e => e.SaveMoney)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_UserComment>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<UP_UserConsume>()
                .Property(e => e.Money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UP_UserConsume>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<U_UserAccount>()
                .Property(e => e.Money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<U_UserInfo>()
                .Property(e => e.Introduce)
                .IsUnicode(false);
        }
    }
}
