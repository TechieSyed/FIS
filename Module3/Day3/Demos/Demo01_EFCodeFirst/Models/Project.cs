using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo01_EFCodeFirst.Models
{
    [Table("ClientProjects")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectCode { get; set; }

        [Required]
        [StringLength(30)]
        public string ProjectTitle { get; set; }

        public decimal Budget { get; set; }

        [Column(TypeName ="date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName ="date")]
        public DateTime? EndDate { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(500)]
        public string Description { get; set; }

        public int TeamSize { get; set; }

        [Required]
        public string ContactPersonDetails { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }

    }
}