using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Implementations;
using TryBeingFit.Services.Interfaces;
using TryBeingFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;

//we want to make Program.cs dependent on interface, Program.cs uses a variable of type IUserService
//that ensures us that the variable will always have a method Register, the implementation can be different
//the implementation depends on the type of the object that we assign to the variable
IUserService<StandardUser> standardUserService = new UserService<StandardUser>();
//IUserService<StandardUser> secondStandarUserService = new SecondUserService<StandardUser>();

IUserService<PremiumUser> premiumUserService = new UserService<PremiumUser>();
IUserService<Trainer> trainerUserService = new UserService<Trainer>();

ITrainingService<LiveTraining> liveTrainingService = new TrainingService<LiveTraining>();
ITrainingService<VideoTraining> videoTrainingService = new TrainingService<VideoTraining>();


//we created this service in order to extract some methods related to input/output so that we clear some space in the main method
IUIService uiService = new UIService();
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
User currentUser = null;
while (true)
{
    if (userOption == 1)
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
            //throw new Exception("Invalid user type option");
            Console.WriteLine("Invalid user type option");
            continue;
        }
        if (typeOption < 1 || typeOption > 3)
        {
            //throw new Exception("Invalid user type option. You need to choose between 1,2 or 3");
            Console.WriteLine("Invalid user type option. You need to choose between 1,2 or 3");
            continue;
        }

        //search for user with the given type, username, password
        UserRoleEnum userRole = (UserRoleEnum)typeOption;


        switch (userRole)
        {
            case UserRoleEnum.Standard:
                //login for standard user
                currentUser = standardUserService.Login(inputUsername, inputPassword);
                break;
            case UserRoleEnum.Premium:
                //login for premium 
                currentUser = premiumUserService.Login(inputUsername, inputPassword);
                break;
            case UserRoleEnum.Trainer:
                //login for trainer
                currentUser = trainerUserService.Login(inputUsername, inputPassword);
                break;
            default:
                currentUser = null;
                break;

        }

        break;
    }
    else if (userOption == 2)
    {
        //register

        //1.get data 
        StandardUser standardUser = uiService.FillRegisterData();

        //2. try to register user
        //Users can only register as standard users
        //the newly registered user is immediatelly logged in
        currentUser = standardUserService.Register(standardUser);
        break;
    }
    else
    {
        Console.WriteLine("Invalid option! You must choose between 1 or 2");
        continue;
    }
}

//Show main menu
string mainMenuOption = uiService.MainMenu(currentUser.UserRole); //Train, Account info, logout...

switch (mainMenuOption)
{
    case "Train":
        if (currentUser.UserRole == UserRoleEnum.Standard)
        {
            videoTrainingService.GetChosenTraining();
        }
        else if (currentUser.UserRole == UserRoleEnum.Premium || currentUser.UserRole == UserRoleEnum.Trainer)
        {
            Console.WriteLine("Enter option: 1)video 2) live");
            string accountInput = Console.ReadLine();
            bool trainingInput = int.TryParse(accountInput, out int trainingOption);
            if (!trainingInput)
            {
                throw new Exception("Wrong input");

            }
            switch (trainingOption)
            {
                case 1:
                    videoTrainingService.GetChosenTraining();
                    break;
                case 2:
                    liveTrainingService.GetChosenTraining();
                    break;
                default:
                    Console.WriteLine("Invalid training option");
                    break;
            }
        }
        break;
    case "Upgrade to premium":
        //1. (optional) validate that current user is standard user - when we add the menu items we make sure it is a standard user
        if(currentUser.UserRole != UserRoleEnum.Standard)
        {
            Console.WriteLine("Only standard users can upgrade to premium");
        }
        //2. current user should not appear among standard users and he/she should belong to premium users

        //2.1 current user should not appear among standard users
        standardUserService.RemoveById(currentUser.Id);

        //2.2 he/she should belong to premium users
        currentUser = premiumUserService.Register(new PremiumUser
        {
            FirstName = currentUser.FirstName,
            LastName = currentUser.LastName,
            Username = currentUser.Username,
            Password = currentUser.Password,
            UserRole = UserRoleEnum.Premium
        });
        break;
    case "Reschedule a training":
        //change the next session on a live training
        //this option should only be available only to trainers
        //the trainer should choose a live training that he wants to reschedule
        //the trainer must be the trainer of that live training

        //(optional)validate that current user is trainer user - when we add the menu items we make sure it is a trainer user
        if (currentUser.UserRole != UserRoleEnum.Trainer)
        {
            throw new Exception("Current user is not a trainer");
        }

        LiveTraining liveTraining = liveTrainingService.GetChosenTraining();
        Console.WriteLine("Please enter days for reschedule");
        bool days = int.TryParse(Console.ReadLine(), out int numOfDays);
        if (!days)
        {
            throw new Exception("Invalid input");
        }
        List<Trainer> trainers = trainerUserService.GetAll();
        trainers.FirstOrDefault(x => x.Username == currentUser.Username).Reschedule(liveTraining, numOfDays);
        //change info
        break;
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