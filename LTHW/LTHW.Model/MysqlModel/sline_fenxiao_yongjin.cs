namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("lthw.sline_fenxiao_yongjin")]
    public partial class sline_fenxiao_yongjin
    {
        public int id { get; set; }

        public int grade { get; set; }

        public decimal? commision { get; set; }

        [StringLength(1073741823)]
        public string remark { get; set; }

        public int? isusing { get; set; }

        public int? isinternal { get; set; }

        public int? flag { get; set; }

        public DateTime? createtime { get; set; }

        public int? createuser { get; set; }

        public DateTime? modifytime { get; set; }

        public int? modifyuser { get; set; }
    }
}
