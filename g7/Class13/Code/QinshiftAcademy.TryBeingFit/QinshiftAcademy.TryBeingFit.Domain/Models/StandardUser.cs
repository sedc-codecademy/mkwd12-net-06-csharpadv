

using QinshiftAcademy.TryBeingFit.Domain.Enums;

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser()
        {
            VideoTrainings = new List<VideoTraining>();
            Type = UserType.StandardUser;
        }
        public override string GetInfo()
        {
            string userInfo = $"{FirstName} {LastName} . \n Video trainings: \n";
            foreach (VideoTraining videoTraining in VideoTrainings)
            {
                userInfo += $"{videoTraining.GetInfo()} \n";
            }

            return userInfo;
        }
    }
}
