namespace Cielo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masa")]
    public partial class Masa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Masa()
        {
            Adisyon = new HashSet<Adisyon>();
            Rezervasyon = new HashSet<Rezervasyon>();
        }

        public int MasaID { get; set; }

        [StringLength(50)]
        public string No { get; set; }

        [StringLength(50)]
        public string Adı { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        public bool? Durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adisyon> Adisyon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rezervasyon { get; set; }
    }
}
