

using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace QinshiftAcademy.TryBeingFit.Domain.DomainInterfaces
{
    public interface ITrainer
    {
        //void RescheduleTraining(LiveTraining liveTraining, DateTime newDate);
        void RescheduleTraining(LiveTraining liveTraining, int days);
    }
}
