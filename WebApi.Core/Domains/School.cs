using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Core.Domains
{
    public class School
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        public required string Name { get; set; }
        [Required()]
        public required string Location { get; set; }


        #region Navigation Properties
        public List<Student> Students { get; }
        #endregion
    }
}
