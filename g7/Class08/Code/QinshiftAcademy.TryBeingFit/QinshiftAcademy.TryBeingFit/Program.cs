using QinshiftAcademy.TryBeingFit.Domain.Database;
using QinshiftAcademy.TryBeingFit.Domain.Enums;
using QinshiftAcademy.TryBeingFit.Domain.Models;

Database<VideoTraining> videoTrainingsDatabase = new Database<VideoTraining>();


videoTrainingsDatabase.Insert(new VideoTraining
{
    Description = "Cardio training",
    Duration = 360,
    Title = "Cardio",
    Rating = 4,
    DifficultyLevel = TrainingDifficultyLevel.Medium
});

videoTrainingsDatabase.Insert(new VideoTraining
{
    Description = "Yoga training",
    Duration = 200,
    Title = "Yoga",
    Rating = 4,
    DifficultyLevel = TrainingDifficultyLevel.Medium
});

List<VideoTraining> videoTrainings = videoTrainingsDatabase.GetAll();

videoTrainingsDatabase.Update(new VideoTraining
{
    Id = 2, // we must send the id in order to find the member of the collection that needs to be replaced
    Description = "Yoga training updated",
    Duration = 200,
    Title = "Yoga 2",
    Rating = 4,
    DifficultyLevel = TrainingDifficultyLevel.Medium
});

VideoTraining yogaVideoTraining = videoTrainingsDatabase.GetById(2);
Console.WriteLine(yogaVideoTraining.Description);

videoTrainingsDatabase.DeleteById(1);
videoTrainings = videoTrainingsDatabase.GetAll();

Console.WriteLine("End");