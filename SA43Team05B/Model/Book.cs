//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA43Team05B.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.IssueTransactions = new HashSet<IssueTransaction>();
        }
    
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public int TotalStock { get; set; }
        public int NumberLeft { get; set; }
        public int ShelfNumber { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueTransaction> IssueTransactions { get; set; }
    }
}
