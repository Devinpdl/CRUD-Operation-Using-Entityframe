namespace MVCCRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int? RollNo { get; set; }

        [StringLength(50)]
        public string Class { get; set; }
    }
}
