//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectionPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public long CandidateId { get; set; }
        public string CandidateName { get; set; }
        public int PostId { get; set; }
        public int VoteCount { get; set; }
    }
}
