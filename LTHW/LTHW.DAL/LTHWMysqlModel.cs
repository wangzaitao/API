namespace LTHW.DAL
{
    using System.Data.Entity;
    using Model;

    public partial class LTHWMysqlModel : DbContext
    {
        public LTHWMysqlModel()
            : base("name=LTHWMysqlModel")
        {
        }

        public virtual DbSet<sline_admin> sline_admin { get; set; }
        public virtual DbSet<sline_advertise> sline_advertise { get; set; }
        public virtual DbSet<sline_advertise_5x> sline_advertise_5x { get; set; }
        public virtual DbSet<sline_advertise_type> sline_advertise_type { get; set; }
        public virtual DbSet<sline_allorderlist> sline_allorderlist { get; set; }
        public virtual DbSet<sline_app> sline_app { get; set; }
        public virtual DbSet<sline_article> sline_article { get; set; }
        public virtual DbSet<sline_article_attr> sline_article_attr { get; set; }
        public virtual DbSet<sline_article_extend_field> sline_article_extend_field { get; set; }
        public virtual DbSet<sline_article_gf> sline_article_gf { get; set; }
        public virtual DbSet<sline_article_kindlist> sline_article_kindlist { get; set; }
        public virtual DbSet<sline_attrorderlist> sline_attrorderlist { get; set; }
        public virtual DbSet<sline_car> sline_car { get; set; }
        public virtual DbSet<sline_car_attr> sline_car_attr { get; set; }
        public virtual DbSet<sline_car_booking> sline_car_booking { get; set; }
        public virtual DbSet<sline_car_brand> sline_car_brand { get; set; }
        public virtual DbSet<sline_car_content> sline_car_content { get; set; }
        public virtual DbSet<sline_car_extend_field> sline_car_extend_field { get; set; }
        public virtual DbSet<sline_car_kind> sline_car_kind { get; set; }
        public virtual DbSet<sline_car_kindlist> sline_car_kindlist { get; set; }
        public virtual DbSet<sline_car_pricelist> sline_car_pricelist { get; set; }
        public virtual DbSet<sline_car_suit> sline_car_suit { get; set; }
        public virtual DbSet<sline_car_suit_price> sline_car_suit_price { get; set; }
        public virtual DbSet<sline_car_suit_type> sline_car_suit_type { get; set; }
        public virtual DbSet<sline_chujing_extend_field> sline_chujing_extend_field { get; set; }
        public virtual DbSet<sline_chujing_kindlist> sline_chujing_kindlist { get; set; }
        public virtual DbSet<sline_comment> sline_comment { get; set; }
        public virtual DbSet<sline_currency> sline_currency { get; set; }
        public virtual DbSet<sline_currency_rate> sline_currency_rate { get; set; }
        public virtual DbSet<sline_customize> sline_customize { get; set; }
        public virtual DbSet<sline_daoyou_extend_field> sline_daoyou_extend_field { get; set; }
        public virtual DbSet<sline_daoyou_kindlist> sline_daoyou_kindlist { get; set; }
        public virtual DbSet<sline_destinations> sline_destinations { get; set; }
        public virtual DbSet<sline_destinations_attr> sline_destinations_attr { get; set; }
        public virtual DbSet<sline_dzorder> sline_dzorder { get; set; }
        public virtual DbSet<sline_email_msg> sline_email_msg { get; set; }
        public virtual DbSet<sline_extend_field> sline_extend_field { get; set; }
        public virtual DbSet<sline_farm> sline_farm { get; set; }
        public virtual DbSet<sline_farm_attr> sline_farm_attr { get; set; }
        public virtual DbSet<sline_farm_content> sline_farm_content { get; set; }
        public virtual DbSet<sline_farm_extend_field> sline_farm_extend_field { get; set; }
        public virtual DbSet<sline_farm_kindlist> sline_farm_kindlist { get; set; }
        public virtual DbSet<sline_farm_pricelist> sline_farm_pricelist { get; set; }
        public virtual DbSet<sline_farm_suit> sline_farm_suit { get; set; }
        public virtual DbSet<sline_feedback> sline_feedback { get; set; }
        public virtual DbSet<sline_help> sline_help { get; set; }
        public virtual DbSet<sline_help_kind> sline_help_kind { get; set; }
        public virtual DbSet<sline_hotel> sline_hotel { get; set; }
        public virtual DbSet<sline_hotel_attr> sline_hotel_attr { get; set; }
        public virtual DbSet<sline_hotel_booking> sline_hotel_booking { get; set; }
        public virtual DbSet<sline_hotel_content> sline_hotel_content { get; set; }
        public virtual DbSet<sline_hotel_extend_field> sline_hotel_extend_field { get; set; }
        public virtual DbSet<sline_hotel_kindlist> sline_hotel_kindlist { get; set; }
        public virtual DbSet<sline_hotel_pricelist> sline_hotel_pricelist { get; set; }
        public virtual DbSet<sline_hotel_rank> sline_hotel_rank { get; set; }
        public virtual DbSet<sline_hotel_room> sline_hotel_room { get; set; }
        public virtual DbSet<sline_huiyi_kindlist> sline_huiyi_kindlist { get; set; }
        public virtual DbSet<sline_icon> sline_icon { get; set; }
        public virtual DbSet<sline_image> sline_image { get; set; }
        public virtual DbSet<sline_image_group> sline_image_group { get; set; }
        public virtual DbSet<sline_insurance> sline_insurance { get; set; }
        public virtual DbSet<sline_insurance_booking> sline_insurance_booking { get; set; }
        public virtual DbSet<sline_insurance_booking_tourer> sline_insurance_booking_tourer { get; set; }
        public virtual DbSet<sline_jieban> sline_jieban { get; set; }
        public virtual DbSet<sline_jieban_attr> sline_jieban_attr { get; set; }
        public virtual DbSet<sline_jieban_join> sline_jieban_join { get; set; }
        public virtual DbSet<sline_jieban_kindlist> sline_jieban_kindlist { get; set; }
        public virtual DbSet<sline_keyword> sline_keyword { get; set; }
        public virtual DbSet<sline_kindorderlist> sline_kindorderlist { get; set; }
        public virtual DbSet<sline_kindset> sline_kindset { get; set; }
        public virtual DbSet<sline_leave> sline_leave { get; set; }
        public virtual DbSet<sline_line> sline_line { get; set; }
        public virtual DbSet<sline_line_attr> sline_line_attr { get; set; }
        public virtual DbSet<sline_line_booking> sline_line_booking { get; set; }
        public virtual DbSet<sline_line_content> sline_line_content { get; set; }
        public virtual DbSet<sline_line_day> sline_line_day { get; set; }
        public virtual DbSet<sline_line_dayspot> sline_line_dayspot { get; set; }
        public virtual DbSet<sline_line_extend> sline_line_extend { get; set; }
        public virtual DbSet<sline_line_extend_field> sline_line_extend_field { get; set; }
        public virtual DbSet<sline_line_jieshao> sline_line_jieshao { get; set; }
        public virtual DbSet<sline_line_kindlist> sline_line_kindlist { get; set; }
        public virtual DbSet<sline_line_month> sline_line_month { get; set; }
        public virtual DbSet<sline_line_pricelist> sline_line_pricelist { get; set; }
        public virtual DbSet<sline_line_spot> sline_line_spot { get; set; }
        public virtual DbSet<sline_line_suit> sline_line_suit { get; set; }
        public virtual DbSet<sline_line_suit_price> sline_line_suit_price { get; set; }
        public virtual DbSet<sline_m_nav> sline_m_nav { get; set; }
        public virtual DbSet<sline_m_page_config> sline_m_page_config { get; set; }
        public virtual DbSet<sline_member> sline_member { get; set; }
        public virtual DbSet<sline_member_grade> sline_member_grade { get; set; }
        public virtual DbSet<sline_member_jifen_log> sline_member_jifen_log { get; set; }
        public virtual DbSet<sline_member_linkman> sline_member_linkman { get; set; }
        public virtual DbSet<sline_member_order> sline_member_order { get; set; }
        public virtual DbSet<sline_member_order_bill> sline_member_order_bill { get; set; }
        public virtual DbSet<sline_member_order_listener> sline_member_order_listener { get; set; }
        public virtual DbSet<sline_member_order_tourer> sline_member_order_tourer { get; set; }
        public virtual DbSet<sline_member_third> sline_member_third { get; set; }
        public virtual DbSet<sline_menu> sline_menu { get; set; }
        public virtual DbSet<sline_model> sline_model { get; set; }
        public virtual DbSet<sline_model_archive> sline_model_archive { get; set; }
        public virtual DbSet<sline_model_attr> sline_model_attr { get; set; }
        public virtual DbSet<sline_model_content> sline_model_content { get; set; }
        public virtual DbSet<sline_model_suit> sline_model_suit { get; set; }
        public virtual DbSet<sline_module_config> sline_module_config { get; set; }
        public virtual DbSet<sline_module_list> sline_module_list { get; set; }
        public virtual DbSet<sline_nav> sline_nav { get; set; }
        public virtual DbSet<sline_nongjiale_extend_field> sline_nongjiale_extend_field { get; set; }
        public virtual DbSet<sline_nongjiale_kindlist> sline_nongjiale_kindlist { get; set; }
        public virtual DbSet<sline_notes> sline_notes { get; set; }
        public virtual DbSet<sline_page> sline_page { get; set; }
        public virtual DbSet<sline_page_config> sline_page_config { get; set; }
        public virtual DbSet<sline_photo> sline_photo { get; set; }
        public virtual DbSet<sline_photo_attr> sline_photo_attr { get; set; }
        public virtual DbSet<sline_photo_extend_field> sline_photo_extend_field { get; set; }
        public virtual DbSet<sline_photo_kindlist> sline_photo_kindlist { get; set; }
        public virtual DbSet<sline_photo_picture> sline_photo_picture { get; set; }
        public virtual DbSet<sline_plugin_autotitle> sline_plugin_autotitle { get; set; }
        public virtual DbSet<sline_plugin_leftnav> sline_plugin_leftnav { get; set; }
        public virtual DbSet<sline_plugin_nav> sline_plugin_nav { get; set; }
        public virtual DbSet<sline_plugins> sline_plugins { get; set; }
        public virtual DbSet<sline_qq_group> sline_qq_group { get; set; }
        public virtual DbSet<sline_qq_kefu> sline_qq_kefu { get; set; }
        public virtual DbSet<sline_question> sline_question { get; set; }
        public virtual DbSet<sline_question_kindlist> sline_question_kindlist { get; set; }
        public virtual DbSet<sline_relationship> sline_relationship { get; set; }
        public virtual DbSet<sline_right> sline_right { get; set; }
        public virtual DbSet<sline_right_module> sline_right_module { get; set; }
        public virtual DbSet<sline_role> sline_role { get; set; }
        public virtual DbSet<sline_search_keyword> sline_search_keyword { get; set; }
        public virtual DbSet<sline_serverlist> sline_serverlist { get; set; }
        public virtual DbSet<sline_site_page> sline_site_page { get; set; }
        public virtual DbSet<sline_site_page_config> sline_site_page_config { get; set; }
        public virtual DbSet<sline_sms_msg> sline_sms_msg { get; set; }
        public virtual DbSet<sline_spot> sline_spot { get; set; }
        public virtual DbSet<sline_spot_attr> sline_spot_attr { get; set; }
        public virtual DbSet<sline_spot_content> sline_spot_content { get; set; }
        public virtual DbSet<sline_spot_extend_field> sline_spot_extend_field { get; set; }
        public virtual DbSet<sline_spot_kindlist> sline_spot_kindlist { get; set; }
        public virtual DbSet<sline_spot_pricelist> sline_spot_pricelist { get; set; }
        public virtual DbSet<sline_spot_ticket> sline_spot_ticket { get; set; }
        public virtual DbSet<sline_spot_ticket_price> sline_spot_ticket_price { get; set; }
        public virtual DbSet<sline_spot_ticket_type> sline_spot_ticket_type { get; set; }
        public virtual DbSet<sline_startplace> sline_startplace { get; set; }
        public virtual DbSet<sline_stats> sline_stats { get; set; }
        public virtual DbSet<sline_supplier> sline_supplier { get; set; }
        public virtual DbSet<sline_supplier_kind> sline_supplier_kind { get; set; }
        public virtual DbSet<sline_sysconfig> sline_sysconfig { get; set; }
        public virtual DbSet<sline_tagword> sline_tagword { get; set; }
        public virtual DbSet<sline_talist> sline_talist { get; set; }
        public virtual DbSet<sline_techan_extend_field> sline_techan_extend_field { get; set; }
        public virtual DbSet<sline_techan_kindlist> sline_techan_kindlist { get; set; }
        public virtual DbSet<sline_templet> sline_templet { get; set; }
        public virtual DbSet<sline_theme> sline_theme { get; set; }
        public virtual DbSet<sline_ticket> sline_ticket { get; set; }
        public virtual DbSet<sline_ticket_airport> sline_ticket_airport { get; set; }
        public virtual DbSet<sline_ticket_booking> sline_ticket_booking { get; set; }
        public virtual DbSet<sline_ticket_company> sline_ticket_company { get; set; }
        public virtual DbSet<sline_tool_link> sline_tool_link { get; set; }
        public virtual DbSet<sline_tuan> sline_tuan { get; set; }
        public virtual DbSet<sline_tuan_attr> sline_tuan_attr { get; set; }
        public virtual DbSet<sline_tuan_booking> sline_tuan_booking { get; set; }
        public virtual DbSet<sline_tuan_content> sline_tuan_content { get; set; }
        public virtual DbSet<sline_tuan_extend_field> sline_tuan_extend_field { get; set; }
        public virtual DbSet<sline_tuan_kindlist> sline_tuan_kindlist { get; set; }
        public virtual DbSet<sline_user_log> sline_user_log { get; set; }
        public virtual DbSet<sline_visa> sline_visa { get; set; }
        public virtual DbSet<sline_visa_> sline_visa_ { get; set; }
        public virtual DbSet<sline_visa_area> sline_visa_area { get; set; }
        public virtual DbSet<sline_visa_booking> sline_visa_booking { get; set; }
        public virtual DbSet<sline_visa_city> sline_visa_city { get; set; }
        public virtual DbSet<sline_visa_content> sline_visa_content { get; set; }
        public virtual DbSet<sline_visa_extend_field> sline_visa_extend_field { get; set; }
        public virtual DbSet<sline_visa_kind> sline_visa_kind { get; set; }
        public virtual DbSet<sline_weblist> sline_weblist { get; set; }
        public virtual DbSet<sline_yqlj> sline_yqlj { get; set; }
        public virtual DbSet<sline_farm_suit_price> sline_farm_suit_price { get; set; }
        public virtual DbSet<sline_hotel_room_price> sline_hotel_room_price { get; set; }
        public virtual DbSet<sline_model_suit_price> sline_model_suit_price { get; set; }
        public virtual DbSet<sline_role_module> sline_role_module { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sline_admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<sline_admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<sline_admin>()
                .Property(e => e.sxw_name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_admin>()
                .Property(e => e.loginip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_admin>()
                .Property(e => e.realname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_admin>()
                .Property(e => e.beizu)
                .IsUnicode(false);

            modelBuilder.Entity<sline_admin>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.tagname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.adposition)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.normalbody)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.expirebody)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.picurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.linkurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.linktext)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.flag)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.custom_label)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.adsrc)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.adlink)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.adname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.adorder)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.is_system)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.is_show)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.is_pc)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.prefix)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_5x>()
                .Property(e => e.finaldestid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_type>()
                .Property(e => e.webid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_type>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<sline_advertise_type>()
                .Property(e => e.tagname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_app>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<sline_app>()
                .Property(e => e.productcode)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.comefrom)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.fromsite)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.kind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.webidfs)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.childkind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.allow)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.ad_position)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.ad_typeid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.ad_productid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.ad_kindid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.redirecturl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.summary)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article>()
                .Property(e => e.attachment)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_gf>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_gf>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_article_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_attrorderlist>()
                .Property(e => e.aid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_attrorderlist>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.carbrand)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.caralt)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.webidfs)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.notice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.satisfyscore)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.bookcount)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_booking>()
                .Property(e => e.carname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_booking>()
                .Property(e => e.info)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_booking>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_booking>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_booking>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_booking>()
                .Property(e => e.bianhao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_brand>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_brand>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_brand>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_brand>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_brand>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_extend_field>()
                .Property(e => e.e_cartext)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_extend_field>()
                .Property(e => e.e_xinneng)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kind>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kind>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kind>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kind>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kind>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kind>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit>()
                .Property(e => e.suitname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit>()
                .Property(e => e.lastoffer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit_price>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit_type>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit_type>()
                .Property(e => e.carid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_car_suit_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_chujing_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_chujing_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_chujing_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_chujing_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_chujing_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_chujing_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_comment>()
                .Property(e => e.articleid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_comment>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_comment>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_currency>()
                .Property(e => e.countryname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_currency>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_currency>()
                .Property(e => e.englishname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_currency>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sline_currency>()
                .Property(e => e.symbol)
                .IsUnicode(false);

            modelBuilder.Entity<sline_currency_rate>()
                .Property(e => e.currencycode1)
                .IsUnicode(false);

            modelBuilder.Entity<sline_currency_rate>()
                .Property(e => e.currencycode2)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.dest)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.startplace)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.planerank)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.hotelrank)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.room)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.food)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.contacttime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.contactname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_customize>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_daoyou_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_daoyou_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_daoyou_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_daoyou_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_daoyou_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_daoyou_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.pinyin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.weburl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.webroot)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.webprefix)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations>()
                .Property(e => e.opentypeids)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_destinations_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_dzorder>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_dzorder>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_dzorder>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<sline_dzorder>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_dzorder>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_dzorder>()
                .Property(e => e.paysource)
                .IsUnicode(false);

            modelBuilder.Entity<sline_email_msg>()
                .Property(e => e.msgtype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_email_msg>()
                .Property(e => e.msg)
                .IsUnicode(false);

            modelBuilder.Entity<sline_extend_field>()
                .Property(e => e.fieldname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_extend_field>()
                .Property(e => e.fieldtype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_extend_field>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_extend_field>()
                .Property(e => e.tips)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.traffic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.aroundspots)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.notice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.equipment)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.opentime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.decoratetime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.bookcount)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.lng)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.lat)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm>()
                .Property(e => e.fuwu)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_suit>()
                .Property(e => e.suitname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_suit>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_suit>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_suit>()
                .Property(e => e.lastoffer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_suit>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_feedback>()
                .Property(e => e.uname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_feedback>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_feedback>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_help>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_help>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<sline_help>()
                .Property(e => e.type_id)
                .IsUnicode(false);

            modelBuilder.Entity<sline_help_kind>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_help_kind>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.lineclass)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.hotelkind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.fuwu)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.hotelpics)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.isding)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.webidfs)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.childkind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.mainrankid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.traffic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.aroundspots)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.notice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.equipment)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.opentime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.decoratetime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.satisfyscore)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.bookcount)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.lng)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel>()
                .Property(e => e.lat)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.hotelname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.hotelrank)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.roomname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.startdate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.dingnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.hotelprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.info)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.dingname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.dingtel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.bianhao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.enddate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_booking>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_extend_field>()
                .Property(e => e.e_engname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_extend_field>()
                .Property(e => e.e_newcontent)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_rank>()
                .Property(e => e.hotelrank)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.roomname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.breakfirst)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.computer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.otherprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.otherroom)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.otherroomurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.nightdays)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.roomids)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.roomstyle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.roomarea)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.roomfloor)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.roomwindow)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.lastoffer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_huiyi_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_huiyi_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_huiyi_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_huiyi_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_huiyi_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_huiyi_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_icon>()
                .Property(e => e.kind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_icon>()
                .Property(e => e.picurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_image>()
                .Property(e => e.image_name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_image>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<sline_image>()
                .Property(e => e.is_hidden)
                .IsUnicode(false);

            modelBuilder.Entity<sline_image_group>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_image_group>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_image_group>()
                .Property(e => e.do_not)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance>()
                .Property(e => e.companykey)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance>()
                .Property(e => e.productcode)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance>()
                .Property(e => e.productname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.bookordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.productcasecode)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.destination)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.trippurposeid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.visacity)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.insureno)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.policyno)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking>()
                .Property(e => e.policyfileid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.pinyin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.cardtype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.cardcode)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.jobcode)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.job)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.fltno)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<sline_insurance_booking_tourer>()
                .Property(e => e.insurantrelation)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.vartime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.lineid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.startdate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.memberid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.userdest)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.usertheme)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_join>()
                .Property(e => e.linkman)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_join>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_jieban_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_keyword>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_keyword>()
                .Property(e => e.linkurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_keyword>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_kindorderlist>()
                .Property(e => e.aid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_kindset>()
                .Property(e => e.aid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_kindset>()
                .Property(e => e.classid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.leavename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.msn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.headimg)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.reply)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.leaveip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.listarea)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.listspot)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.kind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_leave>()
                .Property(e => e.postid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.linetype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.lineicon)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.oldname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.wholesale)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.wholesalel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.startcity)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.overcity)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.linedate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.lineclassid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.linespot)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.linedoc)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.biaozhun)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.beizu)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.payment)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.feeinclude)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.features)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.transport)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.reserved1)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.reserved2)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.reserved3)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.bigpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.childrule)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.webidfs)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.satisfyscore)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.childkind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.txtjieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.isstyle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.zijiaseat)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.zijiaprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.zijiacar)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line>()
                .Property(e => e.insuranceids)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.linename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.dingdate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.dingname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.dingtel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.dingemail)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.dingotherinfo)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_booking>()
                .Property(e => e.bianhao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_dayspot>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_dayspot>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_extend>()
                .Property(e => e.relativeraider)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_extend>()
                .Property(e => e.relativehotel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_extend>()
                .Property(e => e.relativeticket)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_jieshao>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_jieshao>()
                .Property(e => e.breakfirst)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_jieshao>()
                .Property(e => e.transport)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_jieshao>()
                .Property(e => e.hotel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_jieshao>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_jieshao>()
                .Property(e => e.lunch)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_jieshao>()
                .Property(e => e.supper)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_month>()
                .Property(e => e.monthnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_month>()
                .Property(e => e.exname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_month>()
                .Property(e => e.exchange)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_month>()
                .Property(e => e.basicprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_month>()
                .Property(e => e.profit)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_month>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_month>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_spot>()
                .Property(e => e.spotname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_spot>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_suit>()
                .Property(e => e.suitname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_suit>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_suit>()
                .Property(e => e.propgroup)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_suit>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_suit>()
                .Property(e => e.lastoffer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_line_suit_price>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_m_nav>()
                .Property(e => e.m_url)
                .IsUnicode(false);

            modelBuilder.Entity<sline_m_nav>()
                .Property(e => e.m_title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_m_nav>()
                .Property(e => e.m_ico)
                .IsUnicode(false);

            modelBuilder.Entity<sline_m_page_config>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.mtype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.pwd)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.truename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.safequestion)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.safeanswer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.joinip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.loginip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.cardid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.postcode)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.connectid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.from)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_grade>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_jifen_log>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_linkman>()
                .Property(e => e.linkman)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_linkman>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_linkman>()
                .Property(e => e.idcard)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_linkman>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_linkman>()
                .Property(e => e.cardtype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.productname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.usedate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.linkman)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.linktel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.linkemail)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.linkqq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.linkidcard)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.paysource)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.departdate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.distributor)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.consumeverifymemo)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.distributororderexdata)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order>()
                .Property(e => e.supplierorderexdata)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_bill>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_bill>()
                .Property(e => e.receiver)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_bill>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_bill>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_bill>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_bill>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_listener>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_listener>()
                .Property(e => e.distributor)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_listener>()
                .Property(e => e.execute_url)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_listener>()
                .Property(e => e.exdata)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_tourer>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_tourer>()
                .Property(e => e.tourername)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_tourer>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_tourer>()
                .Property(e => e.cardtype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_tourer>()
                .Property(e => e.cardnumber)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_order_tourer>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_third>()
                .Property(e => e.openid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_third>()
                .Property(e => e.from)
                .IsUnicode(false);

            modelBuilder.Entity<sline_member_third>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_menu>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_menu>()
                .Property(e => e.entitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_menu>()
                .Property(e => e.controller)
                .IsUnicode(false);

            modelBuilder.Entity<sline_menu>()
                .Property(e => e.method)
                .IsUnicode(false);

            modelBuilder.Entity<sline_menu>()
                .Property(e => e.ico)
                .IsUnicode(false);

            modelBuilder.Entity<sline_menu>()
                .Property(e => e.extraparam)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model>()
                .Property(e => e.modulename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model>()
                .Property(e => e.pinyin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model>()
                .Property(e => e.correct)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model>()
                .Property(e => e.maintable)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model>()
                .Property(e => e.addtable)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model>()
                .Property(e => e.attrtable)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.satisfyscore)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_archive>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_suit>()
                .Property(e => e.suitname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_suit>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_suit>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_suit>()
                .Property(e => e.sellprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_suit>()
                .Property(e => e.ourprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_suit>()
                .Property(e => e.lastoffer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_module_config>()
                .Property(e => e.pagename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_module_config>()
                .Property(e => e.shortname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_module_config>()
                .Property(e => e.moduleids)
                .IsUnicode(false);

            modelBuilder.Entity<sline_module_list>()
                .Property(e => e.modulename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_module_list>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.typename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.shortname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.linktitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nav>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nongjiale_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nongjiale_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nongjiale_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nongjiale_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nongjiale_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_nongjiale_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.bannerpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.reason)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_notes>()
                .Property(e => e.finaldestid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_page>()
                .Property(e => e.pid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_page>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_page>()
                .Property(e => e.pagename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_page_config>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<sline_page_config>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.alt)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.lineclass)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.webidfs)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.childkind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_picture>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_picture>()
                .Property(e => e.bigpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_photo_picture>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_autotitle>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_autotitle>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_leftnav>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_leftnav>()
                .Property(e => e.linkurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_leftnav>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_leftnav>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_leftnav>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_nav>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_nav>()
                .Property(e => e.linkurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugin_nav>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugins>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugins>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugins>()
                .Property(e => e.datatables)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugins>()
                .Property(e => e.copyright)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugins>()
                .Property(e => e.folder)
                .IsUnicode(false);

            modelBuilder.Entity<sline_plugins>()
                .Property(e => e.identify)
                .IsUnicode(false);

            modelBuilder.Entity<sline_qq_group>()
                .Property(e => e.groupname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_qq_group>()
                .Property(e => e.groupdes)
                .IsUnicode(false);

            modelBuilder.Entity<sline_qq_kefu>()
                .Property(e => e.qqname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_qq_kefu>()
                .Property(e => e.qqnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.replycontent)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.weixin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_question_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_relationship>()
                .Property(e => e.destinationid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_right>()
                .Property(e => e.rightname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_right>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_right_module>()
                .Property(e => e.modulename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_right_module>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_role>()
                .Property(e => e.rolename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_role>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_search_keyword>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_serverlist>()
                .Property(e => e.servername)
                .IsUnicode(false);

            modelBuilder.Entity<sline_serverlist>()
                .Property(e => e.keywords)
                .IsUnicode(false);

            modelBuilder.Entity<sline_serverlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_serverlist>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_site_page>()
                .Property(e => e.pid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_site_page>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_site_page>()
                .Property(e => e.pagename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_site_page_config>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<sline_sms_msg>()
                .Property(e => e.msgtype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_sms_msg>()
                .Property(e => e.msg)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.shortname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.spotpicid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.went)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.want)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.webidfs)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.childkind)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.booknotice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.friendtip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.getway)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.satisfyscore)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.bookcount)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.sellprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.ourprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.memberdayprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.paytype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.bnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.mnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.refundInfo)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.eticketType)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.eticketsmssign)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.eticketsmstemplet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.startdate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.enddate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket>()
                .Property(e => e.lastoffer)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket_price>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket_type>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket_type>()
                .Property(e => e.spotid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_spot_ticket_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_startplace>()
                .Property(e => e.cityname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_startplace>()
                .Property(e => e.domain)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.browser)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.system)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.language)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.referer_domain)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.referer_path)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.access_url)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.searchengine)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.keywords)
                .IsUnicode(false);

            modelBuilder.Entity<sline_stats>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.suppliername)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.linkman)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.kindid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.qualification)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.supplierexdata)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.reason)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier>()
                .Property(e => e.reprent)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier_kind>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_supplier_kind>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<sline_sysconfig>()
                .Property(e => e.varname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_sysconfig>()
                .Property(e => e.info)
                .IsUnicode(false);

            modelBuilder.Entity<sline_sysconfig>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tagword>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tagword>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.tauser)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.face)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.education)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.masterlines)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.product)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.profile)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.mycase)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.msn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.destinations)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.work)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.linkname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_talist>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_techan_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_techan_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_techan_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_techan_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_techan_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_techan_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_templet>()
                .Property(e => e.tempname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_templet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_templet>()
                .Property(e => e.zippath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.aid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.ztname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.shortname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.bgcolor)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.bgimage)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.modtime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_theme>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.startcity)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.midcity)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.overcity)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.taketime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.arrivetime)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.planenum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.flighttypeid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket>()
                .Property(e => e.timerate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_airport>()
                .Property(e => e.planename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_airport>()
                .Property(e => e.domain)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_booking>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_booking>()
                .Property(e => e.cell)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_booking>()
                .Property(e => e.qqmsn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_booking>()
                .Property(e => e.emaill)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_booking>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_booking>()
                .Property(e => e.bianhao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_company>()
                .Property(e => e.companyname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_ticket_company>()
                .Property(e => e.domain)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tool_link>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tool_link>()
                .Property(e => e.linkurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.shortname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.kindlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.attrid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.totalnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.virtualnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.validdate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.piclist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_attr>()
                .Property(e => e.attrname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_attr>()
                .Property(e => e.destid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_attr>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_attr>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.dingnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.info)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.dingname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.dingtel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_booking>()
                .Property(e => e.validdate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_kindlist>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_kindlist>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_kindlist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_kindlist>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_kindlist>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_tuan_kindlist>()
                .Property(e => e.templetpath)
                .IsUnicode(false);

            modelBuilder.Entity<sline_user_log>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<sline_user_log>()
                .Property(e => e.loginfo)
                .IsUnicode(false);

            modelBuilder.Entity<sline_user_log>()
                .Property(e => e.logip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.sellpoint)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.handleday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.validday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.marketprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.feeinclude)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.handlerange)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.areaid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.nationid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.partday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.acceptday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.handlepeople)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.belongconsulate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.enternum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.specialtip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.bookingtip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.material1)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.material2)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.material3)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.material4)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.material5)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.satisfyscore)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.bookcount)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.attachment)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.material)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.booknotice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.circuit)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.friendtip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.tagword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.visatype)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.handleday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.validday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.marketprice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.feeinclude)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.handlerange)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.areaid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.nationid)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.partday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.acceptday)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.handlepeople)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.belongconsulate)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.booknotice)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.material)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.circuit)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.friendtip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.dingjin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.material1)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.material2)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.material3)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.material4)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.material5)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.satisfyscore)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.bookcount)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.iconlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.themelist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.yesjian)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.supplierlist)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.templet)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_>()
                .Property(e => e.specialtip)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.bigpic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.countrypic)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.jieshao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.pinyin)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.seotitle)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_area>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.visaname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.dingnum)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.info)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.dingname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.dingtel)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.ordersn)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.bianhao)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_booking>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_city>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_content>()
                .Property(e => e.columnname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_content>()
                .Property(e => e.chinesename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_visa_kind>()
                .Property(e => e.kindname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_weblist>()
                .Property(e => e.webname)
                .IsUnicode(false);

            modelBuilder.Entity<sline_weblist>()
                .Property(e => e.weburl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_weblist>()
                .Property(e => e.webroot)
                .IsUnicode(false);

            modelBuilder.Entity<sline_weblist>()
                .Property(e => e.webprefix)
                .IsUnicode(false);

            modelBuilder.Entity<sline_yqlj>()
                .Property(e => e.sitename)
                .IsUnicode(false);

            modelBuilder.Entity<sline_yqlj>()
                .Property(e => e.siteurl)
                .IsUnicode(false);

            modelBuilder.Entity<sline_yqlj>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sline_farm_suit_price>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_hotel_room_price>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_model_suit_price>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sline_role_module>()
                .Property(e => e.moduleid)
                .IsUnicode(false);
        }
    }
}
