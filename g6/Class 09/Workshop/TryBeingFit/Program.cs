using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Implementations;
using TryBeingFit.Services.Interfaces;
using TryBeingFit.Domain.Enums;

//we want to make Program.cs dependent on interface, Program.cs uses a variable of type IUserService
//that ensures us that the variable will always have a method Register, the implementation can be different
//the implementation depends on the type of the object that we assign to the variable
IUserService<StandardUser> standardUserService = new UserService<StandardUser>();
//IUserService<StandardUser> secondStandarUserService = new SecondUserService<StandardUser>();

IUserService<PremiumUser> premiumUserService = new UserService<PremiumUser>();
IUserService<Trainer> trainerUserService = new UserService<Trainer>();

ITrainingService<LiveTraining> liveTrainingService = new TrainingService<LiveTraining>();
ITrainingService<VideoTraining> videoTrainingService = new TrainingService<VideoTraining>();

Seed();

//Ask the user to choose an option login/register

Console.Write("Choose an option: 1) Login  2) Register");
string input = Console.ReadLine();
bool success = int.TryParse(input, out int userOption);
if (!success)
{
    throw new Exception("Invalid user option");
}

if(userOption != 1 && userOption != 2)
{
    throw new Exception("Invalid user option! You need to choose between 1 and 2");
}
if(userOption == 1)
{
    //login

    Console.WriteLine("Enter username:");
    string inputUsername = Console.ReadLine();
    if (string.IsNullOrEmpty(inputUsername))
    {
        throw new Exception("You must enter username");
    }

    Console.WriteLine("Enter password:");
    string inputPassword = Console.ReadLine();
    if (string.IsNullOrEmpty(inputPassword))
    {
        throw new Exception("You must enter password");
    }

    Console.WriteLine("Enter your user type: 1)Standard, 2)Premium, 3)Trainer");
    bool successInputType = int.TryParse(Console.ReadLine(), out int typeOption);
    if (!successInputType)
    {
        throw new Exception("Invalid user type option");
    }
    if(typeOption <1 || typeOption > 3)
    {
        throw new Exception("Invalid user type option. You need to choose between 1,2 or 3");
    }

    //search for user with the given type, username, password
}

//seed - put some initial data in the db
void Seed()
{
    StandardUser standardUser = new StandardUser();
    standardUser.FirstName = "Bob";
    standardUser.LastName = "Bobsky";
    standardUser.Username = "bbobsky";
    standardUser.Password = "Test123";

    PremiumUser premiumUser = new PremiumUser
    {
        FirstName = "Ana",
        LastName = "Anovska",
        Username = "aanovska",
        Password = "Test321"
    };

    Trainer trainer = new Trainer();
    trainer.FirstName = "Petko";
    trainer.LastName = "Petkovski";
    trainer.Username = "ppetkovski";
    trainer.Password = "P@ssw0rd";
    trainer.YearsOfExperience = 5;

    standardUserService.Register(standardUser);
    premiumUserService.Register(premiumUser);
    trainerUserService.Register(trainer);

    // secondStandarUserService.Register(standardUser);

    videoTrainingService.AddTraining(new VideoTraining
    {
        Title = "Cardio",
        Description = "Cardio training",
        Time = 35,
        TrainingDifficulty = TrainingDifficultyEnum.Hard,
        Trainer = trainer
    });


    liveTrainingService.AddTraining(new LiveTraining
    {
        Title = "Yoga",
        Description = "Yoga training",
        Time = 30,
        TrainingDifficulty = TrainingDifficultyEnum.Medium,
        Trainer = trainer
    });

}