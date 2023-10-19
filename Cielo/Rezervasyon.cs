namespace Cielo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rezervasyon")]
    public partial class Rezervasyon
    {
        public int RezervasyonID { get; set; }

        public int? MusteriID { get; set; }

        public int? MasaID { get; set; }

        public int? KisiSayisi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Tarih { get; set; }

        public bool? Durum { get; set; }

        public int? personelID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarihi { get; set; }

        public virtual Masa Masa { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
