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
    
    public partial class Special
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Special()
        {
            this.Customer_Order_Line = new HashSet<Customer_Order_Line>();
        }
    
        public int Special_ID { get; set; }
        public string Special_Description { get; set; }
        public System.DateTime Special_Start_Date { get; set; }
        public System.DateTime Special_End_Date { get; set; }
        public decimal Special_Discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Order_Line> Customer_Order_Line { get; set; }
    }
}
