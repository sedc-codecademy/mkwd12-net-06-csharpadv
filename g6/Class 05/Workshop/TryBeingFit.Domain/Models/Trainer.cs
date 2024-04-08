using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class Trainer : User, ITrainer
    {
        public int YearsOfExperience { get; set; }

        public Trainer()
        {
            UserRole = UserRoleEnum.Trainer;
        }
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - {YearsOfExperience} years of experience";
        }

        public void Reschedule (LiveTraining liveTraining, int days)
        {
            if(liveTraining == null)
            {
                throw new NullReferenceException("Training cannot be null");
            }
            //validation if it is the same trainer
            if(Id != liveTraining.Trainer.Id)
            {
                throw new Exception("You cannot reschedule this live training, because you are not the trainer");
            }

            liveTraining.NextSession = liveTraining.NextSession.AddDays(days);

        }
    }
}
