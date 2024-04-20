using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class VideoTraining : Training, IVideoTraining
    {
        public string Link { get; set; }
        public string CheckRating()
        {
            if (Rating == 0)
            {
                return "No rating";
            } else if (Rating < 3)
            {
                return "Bad";
            } else if (Rating < 4)
            {
                return "OK";
            } else if (Rating <= 5)
            {
                return "Good";
            }
            else
            {
                return "Invalid rating";
            }
        }

        public override string GetInfo()
        {
            return $"{Title} - {Description}, lasts: {Time}, difficulty: {TrainingDifficulty.ToString()}, link [{Link}]";
        }
    }
}
