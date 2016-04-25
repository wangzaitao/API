namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class S_FXCommision
    {
        public long ID { get; set; }

        public decimal First { get; set; }

        public decimal Second { get; set; }

        public decimal Third { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }

        public byte? IsUsing { get; set; }

        public byte? IsInternat { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
