//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamSpur
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPinSubscription
    {
        public int PinId { get; set; }
        public string PinNumber { get; set; }
        public System.DateTime DateGenerated { get; set; }
        public bool PinStatus { get; set; }
        public string Username { get; set; }
        public Nullable<int> BatchId { get; set; }
        public string UsedBy { get; set; }
    }
}