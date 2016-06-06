namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_leave")]
    public partial class sline_leave
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(100)]
        public string ip { get; set; }

        [StringLength(50)]
        public string leavename { get; set; }

        [StringLength(50)]
        public string qq { get; set; }

        [StringLength(50)]
        public string msn { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(11)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(50)]
        public string headimg { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [StringLength(1073741823)]
        public string reply { get; set; }

        [Column(TypeName = "uint")]
        public long? retime { get; set; }

        [Column(TypeName = "uint")]
        public long? approval { get; set; }

        public int? ishidden { get; set; }

        [StringLength(50)]
        public string leaveip { get; set; }

        [StringLength(255)]
        public string listarea { get; set; }

        [StringLength(255)]
        public string listspot { get; set; }

        public int? ismaill { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ismust { get; set; }

        [StringLength(255)]
        public string kind { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string postid { get; set; }
    }
}