namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class UP_CommentImage
    {
        public long ID { get; set; }

        public long CommentID { get; set; }

        [StringLength(200)]
        public string ImgUrl { get; set; }

        [StringLength(20)]
        public string ImgType { get; set; }

        public byte? Isshow { get; set; }
    }
}
