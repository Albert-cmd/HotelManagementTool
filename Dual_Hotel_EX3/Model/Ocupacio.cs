//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dual_Hotel_EX3.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ocupacio
    {
        public int IDOcupacio { get; set; }
        public int IDHoste { get; set; }
        public int NumHabitacio { get; set; }
    
        public virtual Habitacio Habitacio { get; set; }
        public virtual Hoste Hoste { get; set; }
    }
}
