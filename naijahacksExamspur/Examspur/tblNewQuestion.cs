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
    
    public partial class tblNewQuestion
    {
        public long QuestionID { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string OptionE { get; set; }
        public int SubjectID { get; set; }
        public Nullable<int> HasImage { get; set; }
        public string Answer { get; set; }
        public Nullable<int> NoOfOptions { get; set; }
        public Nullable<bool> Trial { get; set; }
        public Nullable<int> ImageId { get; set; }
        public Nullable<long> QuestionNumber { get; set; }
    }
}