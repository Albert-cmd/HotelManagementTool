//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dual_Hotel_EX3.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hoste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoste()
        {
            this.Ocupacios = new HashSet<Ocupacio>();
        }

        public Hoste(string nom, string dNIPasaport, string telefon, string nacionalitat, string adreca, int codipostal, string poblacio)
        {
            Nom = nom;
            DNIPasaport = dNIPasaport;
            Telefon = telefon;
            Nacionalitat = nacionalitat;
            Adreca = adreca;
            Codipostal = codipostal;
            Poblacio = poblacio;
<<<<<<< Updated upstream

            this.Ocupacios = new HashSet<Ocupacio>();
=======
>>>>>>> Stashed changes
        }

        public int IDHoste { get; set; }
        public string Nom { get; set; }
        public string DNIPasaport { get; set; }
        public string Telefon { get; set; }
        public string Nacionalitat { get; set; }
        public string Adreca { get; set; }
        public int Codipostal { get; set; }
        public string Poblacio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocupacio> Ocupacios { get; set; }
    }
}
