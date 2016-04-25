namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class UP_CommentReply
    {
        public long ID { get; set; }

        public long PID { get; set; }

        public long CommentID { get; set; }

        public long ReplyUserID { get; set; }

        public DateTime Time { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public byte? Isshow { get; set; }
    }
}
