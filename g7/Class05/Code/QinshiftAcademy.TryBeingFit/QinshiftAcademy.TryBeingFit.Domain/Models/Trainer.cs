

using QinshiftAcademy.TryBeingFit.Domain.DomainInterfaces;

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public class Trainer : User, ITrainer
    {
        public int YearsOfExperience { get; set; }
        //option - have the live trainings that the trainer is responsible for
        public override string GetInfo()
        {
            return $"{FirstName} {LastName}, years of experience: {YearsOfExperience}";
        }

        public void RescheduleTraining(LiveTraining liveTraining, int days)
        {
            if(liveTraining.Trainer != null && liveTraining.Trainer.Username == Username)
            {
                liveTraining.NextSession.AddDays(days);
            }

            Console.WriteLine("The trainer is not responsible for the given training");
        }
    }
}
