//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIIProject_travel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tActivity()
        {
            this.tBlogComment = new HashSet<tBlogComment>();
        }
    
        public int f活動編號 { get; set; }
        public int f會員編號 { get; set; }
        public string f活動類型 { get; set; }
        public string f活動內容 { get; set; }
        public string f活動發起日期 { get; set; }
        public string f活動開始時間 { get; set; }
        public string f活動結束時間 { get; set; }
        public string f活動招募截止時間 { get; set; }
        public string f活動標題 { get; set; }
        public string f活動地區 { get; set; }
        public string f活動地點 { get; set; }
        public Nullable<int> f活動預算 { get; set; }
        public Nullable<int> f活動瀏覽次數 { get; set; }
        public Nullable<int> f活動讚數 { get; set; }
        public string f活動分類 { get; set; }
        public string f活動標籤 { get; set; }
        public string f活動團圖 { get; set; }
        public string f活動按過讚的會員編號 { get; set; }
        public Nullable<double> f活動經度 { get; set; }
        public Nullable<double> f活動緯度 { get; set; }
        public string f活動所屬 { get; set; }
        public string f活動參加的會員編號 { get; set; }
        public string f活動留言 { get; set; }
        public string f活動留言時間 { get; set; }
        public string f活動評分過的會員編號 { get; set; }
        public string fQRcode網址 { get; set; }
        public string fQRcodeImage { get; set; }
        public string f有收藏活動的會員編號 { get; set; }
        public string f活動審核名單 { get; set; }
    
        public virtual tMember tMember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tBlogComment> tBlogComment { get; set; }
    }
}
