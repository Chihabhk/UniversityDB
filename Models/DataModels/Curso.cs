using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string shortDescription { get; set; } = string.Empty;

        public string? largeDescription { get; set; }

        public string targetAudience { get; set; } = string.Empty;

        public string objectives { get; set; } = string.Empty;

        [Required]
        public string? requirements { get; set; }

        public enum level {Basic, Intermediate, Advanced}

    }
}
