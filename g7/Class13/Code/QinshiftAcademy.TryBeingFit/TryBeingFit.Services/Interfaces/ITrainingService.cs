using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface ITrainingService<T> where T : Training
    {
        List<T> GetAllTraining();
        T GetTraining(int id);
        void AddTraining(T training);
    }
}
