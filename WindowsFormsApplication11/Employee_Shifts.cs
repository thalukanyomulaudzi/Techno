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
    
    public partial class Employee_Shifts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Shifts()
        {
            this.Employee_Booking_Shift = new HashSet<Employee_Booking_Shift>();
        }
    
        public int Employee_Shift_ID { get; set; }
        public System.DateTime Employee_Shift_Date { get; set; }
        public string Employee_Shift_Time_Slot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Booking_Shift> Employee_Booking_Shift { get; set; }
    }
}