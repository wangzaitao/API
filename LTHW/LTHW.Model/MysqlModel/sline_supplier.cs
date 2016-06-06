namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_supplier")]
    public partial class sline_supplier
    {
        public int id { get; set; }

        [StringLength(255)]
        public string suppliername { get; set; }

        [StringLength(100)]
        public string linkman { get; set; }

        [StringLength(100)]
        public string telephone { get; set; }

        [StringLength(100)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string qq { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(255)]
        public string kindid { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        public double? lng { get; set; }

        public double? lat { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(500)]
        public string piclist { get; set; }

        public int? finaldestid { get; set; }

        [StringLength(255)]
        public string account { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        public int? verifystatus { get; set; }

        public int? displayorder { get; set; }

        [StringLength(1073741823)]
        public string qualification { get; set; }

        public int? logintime { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [StringLength(50)]
        public string province { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        public int? suppliertype { get; set; }

        [StringLength(1073741823)]
        public string supplierexdata { get; set; }

        [StringLength(500)]
        public string reason { get; set; }

        [StringLength(100)]
        public string reprent { get; set; }

        public float creditamount { get; set; }
    }
}
