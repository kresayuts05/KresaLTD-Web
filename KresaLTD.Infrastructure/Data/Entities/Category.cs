using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KresaLTD.Infrastructure.Data.Constants.ModelConstraints.CategoryConstants;

namespace KresaLTD.Infrastructure.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public ICollection<Project> Projects { get; set; } = new HashSet<Project>();
    }
}
