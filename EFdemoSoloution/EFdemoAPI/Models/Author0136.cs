//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFdemoAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Author0136
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Author0136()
        {
            this.Book0136 = new HashSet<Book0136>();
        }
    
        public int AuthorsID { get; set; }
        public string AuthorsFirstName { get; set; }
        public string AuthorsSurname { get; set; }
        public int AuthorsTaxFileNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book0136> Book0136 { get; set; }
    }
}
