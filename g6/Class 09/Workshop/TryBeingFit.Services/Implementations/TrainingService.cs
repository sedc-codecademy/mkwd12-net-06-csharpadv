
using TryBeingFit.Domain.Database;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementations
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        //Service communicates with db
        //we use the interface - we dont want to be dependent on the implementation

        private IDatabase<T> _database;

        public TrainingService()
        {
            _database = new Database<T>();  
        }
        public void AddTraining(T newTraining)
        {
           //1.validation
           if(newTraining == null)
            {
                throw new NullReferenceException("Training cannot be null");
            }
            //validation title is required
            if (string.IsNullOrEmpty(newTraining.Title))
            {
                throw new Exception("Title cannot be empty");
            }
            //validation duration must be at least 10 min
            if (!ValidationHelper.ValidateTrainingDuration(newTraining.Time))
            {
                throw new Exception("Each training must be at least 10 minutes");
            }
            //must have a trainer
            if(newTraining.Trainer == null)
            {
                throw new Exception("Each training must have a trainer");
            }
            //2.insert into db
            _database.Insert(newTraining);

        }
    }
}
