using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KresaLTD.Infrastructure.Data.Constants.ModelConstraints.ProjectConstants;

namespace KresaLTD.Infrastructure.Data.Entities
{
    public class Project
    {
        public Project()
        {
            this.CreatedOn = DateTime.Now;
            IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(ShortContentMaxLength)]
        public string ShortContent { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<Image> Image { get; set; } = new HashSet<Image>();

        public ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }
}