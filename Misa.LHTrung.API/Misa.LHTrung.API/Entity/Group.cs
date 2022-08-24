namespace Misa.LHTrung.API.Entity
{
/*Tổ chuyên môn*/
    public class Group
    {
        // id tổ chuyên môn
        public Guid GroupID { get; set; }

        // mã tổ chuyên môn
        public string GroupCode { get; set; }

        // tên tổ chuyên môn
        public string GroupName { get; set; }

        // ngày tạo 
        public DateTime CreatedDate { get; set; }

        // người tạo
        public string CreatedBy { get; set; }

        // ngày sửa dổi
        public DateTime ModifiedDate { get; set; }

        // người sửa đổi
        public string ModifiedBy { get; set; }
    }
}
