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
    
    public partial class C_tblQuestionWAEC
    {
        public long QuestionID { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string OptionE { get; set; }
        public int SubjectID { get; set; }
        public int HasImage { get; set; }
        public string Answer { get; set; }
        public Nullable<int> NoOfOptions { get; set; }
        public Nullable<bool> trial { get; set; }
        public Nullable<int> ImageId { get; set; }
        public long QuestionNumber { get; set; }
        public string Solution { get; set; }
        public Nullable<int> TopicId { get; set; }
        public Nullable<int> GroupId { get; set; }
        public string UserName { get; set; }
    
        public virtual C_ExamGroup C_ExamGroup { get; set; }
        public virtual C_tblSubjectGeneral C_tblSubjectGeneral { get; set; }
        public virtual C_tblTopics C_tblTopics { get; set; }
    }
}
