namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class UP_UserComment
    {
        public long ID { get; set; }

        public long PID { get; set; }

        public long UserID { get; set; }

        public long PdtID { get; set; }

        [StringLength(200)]
        public string PdtName { get; set; }

        public DateTime Time { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public int? Level { get; set; }

        public byte? IsImage { get; set; }

        public byte? Isshow { get; set; }

        public byte? IsReply { get; set; }
    }
}
