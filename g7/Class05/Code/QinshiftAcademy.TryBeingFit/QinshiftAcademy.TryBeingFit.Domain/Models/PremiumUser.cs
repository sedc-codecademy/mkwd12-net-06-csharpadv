

using QinshiftAcademy.TryBeingFit.Domain.Enums;

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public class PremiumUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }

        public PremiumUser(LiveTraining liveTraining)
        {
            VideoTrainings = new List<VideoTraining>();
            LiveTraining = liveTraining;
            Type = UserType.PremiumUser;
        }

        public override string GetInfo()
        {
            string trainingInfo = LiveTraining != null ? "The user has a live training \n" : "The user doesn't have a live training \n";

            trainingInfo += $"{FirstName} {LastName} Video training count: {VideoTrainings.Count}";

            return trainingInfo;
        }
    }
}
