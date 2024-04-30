using QinshiftAcademy.TryBeingFit.Domain.Database;
using QinshiftAcademy.TryBeingFit.Domain.Models;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.implementations
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        private IDatabase<T> _database;

        public TrainingService()
        {
            _database = new Database<T>();
        }

        public void AddTraining(T training)
        {
            //validation
            if(string.IsNullOrEmpty(training.Title))
            {
                throw new Exception("Title must not be empty");
            }
            _database.Insert(training);
        }

        public List<T> GetAllTraining()
        {
            return _database.GetAll();
        }

        public T GetTraining(int id)
        {
            return _database.GetById(id);
        }
    }
}
