using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KresaLTD.Infrastructure.Data.Constants.ModelConstraints.ReviewConstants;

namespace KresaLTD.Infrastructure.Data.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FullUserNameMaxLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [MaxLength(FullUserNameMaxLength)]
        public string CommentText { get; set; } = null!;

        [Required]
        [Range(typeof(int), RatingMinValue, RatingMaxValue)]
        public int Rating { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public ICollection<Image> Image { get; set; } = new HashSet<Image>();
    }
}
