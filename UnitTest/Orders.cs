//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Admininstration = new HashSet<Admininstration>();
        }
    
        public int IDOrder { get; set; }
        public int NumberOrder { get; set; }
        public System.DateTime DateOrder { get; set; }
        public int CostOrder { get; set; }
        public int IDStatusOrder { get; set; }
        public int IDBook { get; set; }
        public int IDCustomer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admininstration> Admininstration { get; set; }
        public virtual Books Books { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual StatusOrder StatusOrder { get; set; }
    }
}
