using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Interfaces
{
    public interface ITrainer
    {
        void Reschedule(LiveTraining liveTraining, int days);
    }
}
