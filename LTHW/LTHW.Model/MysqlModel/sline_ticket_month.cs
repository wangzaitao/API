namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_ticket_month")]
    public partial class sline_ticket_month
    {
        public int id { get; set; }

        public int? ticketid { get; set; }

        public int? yearnum { get; set; }

        [StringLength(255)]
        public string monthnum { get; set; }

        public int? day1 { get; set; }

        public int? day2 { get; set; }

        public int? day3 { get; set; }

        public int? day4 { get; set; }

        public int? day5 { get; set; }

        public int? day6 { get; set; }

        public int? day7 { get; set; }

        public int? day8 { get; set; }

        public int? day9 { get; set; }

        public int? day10 { get; set; }

        public int? day11 { get; set; }

        public int? day12 { get; set; }

        public int? day13 { get; set; }

        public int? day14 { get; set; }

        public int? day15 { get; set; }

        public int? day16 { get; set; }

        public int? day17 { get; set; }

        public int? day18 { get; set; }

        public int? day19 { get; set; }

        public int? day20 { get; set; }

        public int? day21 { get; set; }

        public int? day22 { get; set; }

        public int? day23 { get; set; }

        public int? day24 { get; set; }

        public int? day25 { get; set; }

        public int? day26 { get; set; }

        public int? day27 { get; set; }

        public int? day28 { get; set; }

        public int? day29 { get; set; }

        public int? day30 { get; set; }

        public int? day31 { get; set; }

        [StringLength(255)]
        public string description1 { get; set; }

        [StringLength(255)]
        public string description2 { get; set; }

        [StringLength(255)]
        public string description3 { get; set; }

        [StringLength(255)]
        public string description4 { get; set; }

        [StringLength(255)]
        public string description5 { get; set; }

        [StringLength(255)]
        public string description6 { get; set; }

        [StringLength(255)]
        public string description7 { get; set; }

        [StringLength(255)]
        public string description8 { get; set; }

        [StringLength(255)]
        public string description9 { get; set; }

        [StringLength(255)]
        public string description10 { get; set; }

        [StringLength(255)]
        public string description11 { get; set; }

        [StringLength(255)]
        public string description12 { get; set; }

        [StringLength(255)]
        public string description13 { get; set; }

        [StringLength(255)]
        public string description14 { get; set; }

        [StringLength(255)]
        public string description15 { get; set; }

        [StringLength(255)]
        public string description16 { get; set; }

        [StringLength(255)]
        public string description17 { get; set; }

        [StringLength(255)]
        public string description18 { get; set; }

        [StringLength(255)]
        public string description19 { get; set; }

        [StringLength(255)]
        public string description20 { get; set; }

        [StringLength(255)]
        public string description21 { get; set; }

        [StringLength(255)]
        public string description22 { get; set; }

        [StringLength(255)]
        public string description23 { get; set; }

        [StringLength(255)]
        public string description24 { get; set; }

        [StringLength(255)]
        public string description25 { get; set; }

        [StringLength(255)]
        public string description26 { get; set; }

        [StringLength(255)]
        public string description27 { get; set; }

        [StringLength(255)]
        public string description28 { get; set; }

        [StringLength(255)]
        public string description29 { get; set; }

        [StringLength(255)]
        public string description30 { get; set; }

        [StringLength(255)]
        public string description31 { get; set; }
    }
}
