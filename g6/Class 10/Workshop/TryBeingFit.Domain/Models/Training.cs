using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Enums;

namespace TryBeingFit.Domain.Models
{
    public abstract class Training : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Time {  get; set; }

        public double Rating { get; set; }

        public Trainer Trainer { get; set; }

        public TrainingDifficultyEnum TrainingDifficulty { get; set; }
    }
}
