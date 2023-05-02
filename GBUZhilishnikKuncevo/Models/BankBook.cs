//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GBUZhilishnikKuncevo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankBook()
        {
            this.Accounting = new HashSet<Accounting>();
            this.TotalCheck = new HashSet<TotalCheck>();
        }
    
        public int id { get; set; }
        public string bankBookNumber { get; set; }
        public int apartmentId { get; set; }
        public string organization { get; set; }
        public int proprietaryId { get; set; }
        public int typeOfOwnershipId { get; set; }
        public int clientId { get; set; }

        public string fullName => $"{Client.surname} {Client.name} {Client.patronymic}";
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accounting> Accounting { get; set; }
        public virtual Apartment Apartment { get; set; }
        public virtual Client Client { get; set; }
        public virtual Ownership Ownership { get; set; }
        public virtual Proprietary Proprietary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TotalCheck> TotalCheck { get; set; }
    }
}
