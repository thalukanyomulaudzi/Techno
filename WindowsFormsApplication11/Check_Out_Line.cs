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
    
    public partial class Check_Out_Line
    {
        public int Check_Out_Line_ID { get; set; }
        public Nullable<int> Stock_ID { get; set; }
        public Nullable<int> Check_Out_ID { get; set; }
        public double Quaantity { get; set; }
        public byte[] Stock_Item_Name { get; set; }
    
        public virtual Check_Out Check_Out { get; set; }
        public virtual Stock_Item Stock_Item { get; set; }
    }
}
