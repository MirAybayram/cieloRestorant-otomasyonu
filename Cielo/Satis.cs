namespace Cielo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        public int SatisID { get; set; }

        public int? AdisyonID { get; set; }

        public int? UrunID { get; set; }

        public int? Adet { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        public virtual Adisyon Adisyon { get; set; }

        public virtual Urun Urun { get; set; }

        public virtual Urun Urun1 { get; set; }
    }
}
