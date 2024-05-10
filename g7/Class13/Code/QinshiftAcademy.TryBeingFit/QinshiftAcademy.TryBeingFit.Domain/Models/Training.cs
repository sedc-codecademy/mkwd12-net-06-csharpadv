using QinshiftAcademy.TryBeingFit.Domain.Enums;

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public abstract class Training : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        public TrainingDifficultyLevel DifficultyLevel { get; set; }
        public double? Rating { get; set; }
    }
}
