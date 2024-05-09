using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface ITrainingService<T> where T : Training
    {
        void AddTraining(T newTraining);

        T GetChosenTraining();
    }
}
