namespace Cielo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urun")]
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            Satis = new HashSet<Satis>();
            Satis1 = new HashSet<Satis>();
        }

        public int UrunID { get; set; }

        public int? KategoriID { get; set; }

        [StringLength(100)]
        public string UrunAdi { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fiyat { get; set; }

        public bool? Durum { get; set; }

        public virtual Kategori Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis1 { get; set; }
    }
}
