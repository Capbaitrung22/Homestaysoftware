//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homestaylist
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public int ID { get; set; }
        public string Room_Name { get; set; }
        public string Status { get; set; }
        public string Space { get; set; }
        public string Price { get; set; }
        public int Homestayown_ID { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Homestayown Homestayown { get; set; }
    }
}
