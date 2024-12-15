namespace QUANLSV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(80)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Fullname { get; set; }

        public double Average { get; set; }

        public int FacultyID { get; set; }
        // Thêm thuộc tính điều hướng đến đối tượng Faculty
        [ForeignKey("FacultyID")]
        public virtual Faculty Faculty { get; set; } // Đây là thuộc tính điều hướng
    }
}
