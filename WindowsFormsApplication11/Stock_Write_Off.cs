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
    
    public partial class Stock_Write_Off
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stock_Write_Off()
        {
            this.Stock_WriteOff_Line = new HashSet<Stock_WriteOff_Line>();
        }
    
        public int Write_Off_ID { get; set; }
        public string WriteOff_Stock_Name { get; set; }
        public int Stock_WriteOff_Quantity { get; set; }
        public string Employee_ID { get; set; }
        public string WriteOff_Reason { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_WriteOff_Line> Stock_WriteOff_Line { get; set; }
    }
}
