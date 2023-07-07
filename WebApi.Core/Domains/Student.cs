using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Core.Domains
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [MinLength(3)]
        public required string FirstName { get; set; }
        [Required()]
        [MinLength(3)]
        public required string LastName { get; set; }
        [Required()]
        [Range(1, 20)]
        public required double Average { get; set; }


        #region Navigation Properties
        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public School School { get; set; }
        #endregion
    }
}
