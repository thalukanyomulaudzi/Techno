//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication11
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
            this.Customer_Order_Line = new HashSet<Customer_Order_Line>();
        }
    
        public int Payment_ID { get; set; }
        public System.DateTime Payment_Date { get; set; }
        public decimal Payment_Amount { get; set; }
        public Nullable<int> Payment_Type_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Order_Line> Customer_Order_Line { get; set; }
        public virtual Payment_Type Payment_Type { get; set; }
    }
}