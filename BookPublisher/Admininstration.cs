//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookPublisher
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admininstration
    {
        public int IDAdministration { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> IDOrder { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
