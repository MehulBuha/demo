//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticalDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_user2
    {
        public int Userid { get; set; }

        [Required(ErrorMessage ="Name is Mandatory")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Email is Mandatory")]
   
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
            
        [Required(ErrorMessage ="MobileNo is Mandatory")]

        public string phonno { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
    }
}