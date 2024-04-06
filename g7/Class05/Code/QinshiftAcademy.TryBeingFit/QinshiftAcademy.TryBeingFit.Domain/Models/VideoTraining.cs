

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public class VideoTraining : Training
    {
        public int Rating { get; set; }
        public string Link { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - {Duration}. Rating: {Rating}, link: {Link}";
        }
    }
}
