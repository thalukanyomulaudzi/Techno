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
    
    public partial class Stock_Combo_Line
    {
        public Nullable<int> Stock_ID { get; set; }
        public Nullable<int> Combo_ID { get; set; }
        public string Stock_Item_Name { get; set; }
        public int Stock_Item_Quantity { get; set; }
        public int Stock_Combo_Line_ID { get; set; }
    
        public virtual Combo Combo { get; set; }
        public virtual Stock_Item Stock_Item { get; set; }
    }
}
