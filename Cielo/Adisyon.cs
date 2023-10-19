namespace Cielo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adisyon")]
    public partial class Adisyon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adisyon()
        {
            Satis = new HashSet<Satis>();
        }

        public int AdisyonID { get; set; }

        public int? PersonelID { get; set; }

        public int? MasaID { get; set; }

        public DateTime? Tarih { get; set; }

        public bool? Durum { get; set; }

        public virtual Masa Masa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
