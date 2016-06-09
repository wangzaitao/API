namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_ticket")]
    public partial class sline_ticket
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(50)]
        public string startcity { get; set; }

        [StringLength(50)]
        public string midcity { get; set; }

        [StringLength(50)]
        public string overcity { get; set; }

        [Column(TypeName = "uint")]
        public long? tickettype { get; set; }

        [StringLength(255)]
        public string taketime { get; set; }

        [StringLength(255)]
        public string arrivetime { get; set; }

        [StringLength(255)]
        public string company { get; set; }

        [StringLength(255)]
        public string planenum { get; set; }

        [StringLength(255)]
        public string flighttypeid { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        public int ismiddle { get; set; }

        [StringLength(255)]
        public string timerate { get; set; }

        public int? hasrepast { get; set; }
    }
}
