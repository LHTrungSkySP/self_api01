namespace Misa.LHTrung.API.Entity
{
    /*Môn*/
    public class Subject
    {
        /*id môn học */
        public Guid SubjectID { get; set; }

        //mã môn học 
        public string SubjectCode { get; set; }

        //tên môn học 
        public string SubjectName { get; set; }

        //ngày tạo môn học
        public DateTime CreatedDate { get; set; }

        //người tạo môn học 
        public string CreatedBy { get; set; }

        //ngày sửa dổi 
        public DateTime ModifiedDate { get; set; }

        // người sửa dổi
        public string ModifiedBy { get; set; }
    }
}
