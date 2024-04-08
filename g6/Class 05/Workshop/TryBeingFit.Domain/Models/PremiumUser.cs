using TryBeingFit.Domain.Enums;

namespace TryBeingFit.Domain.Models
{
    public class PremiumUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }

        public PremiumUser() {

            UserRole = UserRoleEnum.Premium;
            VideoTrainings = new List<VideoTraining>();

        }
        public override string GetInfo()
        {
            string liveTrainingMessage = LiveTraining == null ? " no live training" : LiveTraining.Title;
            return $"{FirstName} {LastName}, num of video trainings {VideoTrainings.Count}, live training: {liveTrainingMessage}";
        }
    }
}
