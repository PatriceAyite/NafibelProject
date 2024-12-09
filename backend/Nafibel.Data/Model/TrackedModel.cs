using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    public class TrackedModel
    {
        [Required]
        public string CreatedBy { get; set; } = string.Empty;
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string ModifiedBy { get; set; } = string.Empty;
        [Required]
        public DateTime ModifiedOn { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
