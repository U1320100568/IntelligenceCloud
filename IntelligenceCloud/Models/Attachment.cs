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
    
    public partial class Attachment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attachment()
        {
            this.AttachmentRecord = new HashSet<AttachmentRecord>();
        }
    
        public int AttachmentId { get; set; }
        public string AttachmentPath { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentOriginName { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentUse { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string MemberShared { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> UploadTime { get; set; }
        public Nullable<System.DateTime> DeletedTime { get; set; }
        public Nullable<System.DateTime> DownloadTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttachmentRecord> AttachmentRecord { get; set; }
    }
}