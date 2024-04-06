

using QinshiftAcademy.TryBeingFit.Domain.DomainInterfaces;

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }
        public Trainer Trainer { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - {Duration}. Next session: {NextSession}";
        }

        public int HoursTillNextSession()
        {
            return (NextSession - DateTime.Now).Hours;
        }
    }
}
