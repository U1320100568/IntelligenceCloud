//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligenceCloud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ForensicContact
    {
        public int ForensicContactID { get; set; }
        public Nullable<int> AttachmentId { get; set; }
        public Nullable<int> FSheetNum { get; set; }
        public string FSheetName { get; set; }
        public Nullable<int> FNum { get; set; }
        public string FName { get; set; }
        public string FGroup { get; set; }
        public Nullable<System.DateTime> FModifiedTime { get; set; }
        public string FClause { get; set; }
        public string FNote { get; set; }
        public string FSource { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    }
}