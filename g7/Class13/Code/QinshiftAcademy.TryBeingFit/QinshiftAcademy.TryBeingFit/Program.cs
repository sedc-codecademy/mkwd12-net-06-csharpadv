using QinshiftAcademy.TryBeingFit.Domain.Database;
using QinshiftAcademy.TryBeingFit.Domain.Enums;
using QinshiftAcademy.TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.implementations;
using TryBeingFit.Services.Interfaces;

Database<VideoTraining> videoTrainingsDatabase = new Database<VideoTraining>();

ITrainingService<LiveTraining> _liveTrainingService = new TrainingService<LiveTraining>();
ITrainingService<VideoTraining> _videoTrainingService = new TrainingService<VideoTraining>();
IUserService<Trainer> _trainerService = new UserService<Trainer>();
IUserService<StandardUser> _standardUserService = new UserService<StandardUser>();
IUserService<PremiumUser> _premiumUserService = new UserService<PremiumUser>();
IUiService _uiService = new UiService();
User _currentUser = null;

//Seed();

int option = _uiService.LogInMenu();
Console.Clear();
if (option == 1)
{
    int roleChoice = _uiService.RoleMenu();
    Console.WriteLine("enter Username:");
    string username = Console.ReadLine();
    if(string.IsNullOrEmpty(username) )
    {
        throw new Exception("you must enter username");
    }
    Console.WriteLine("Enter password");
    string password = Console.ReadLine();
    if (string.IsNullOrEmpty(password))
    {
        throw new Exception("you must enter password");
    }
    UserType type = (UserType)roleChoice;
    switch (type)
    {
        case UserType.StandardUser:
            _currentUser = _standardUserService.Login(username, password);
            break;
        case UserType.PremiumUser:
            _currentUser = _premiumUserService.Login(username, password);
            break;
        case UserType.Trainer:
            _currentUser = _trainerService.Login(username, password);
            break;

    }
}
else
{
    StandardUser standardUser = _uiService.FillNewUserData();
    _currentUser = _standardUserService.Register(standardUser);
}


int mainMenuOption = _uiService.MainMenu(_currentUser.Type);
string menuItem = _uiService.MenuItems[mainMenuOption - 1];

switch (menuItem)
{
    case "Train":
        int trainOption = 1;
        if(_currentUser.Type == UserType.PremiumUser)
        {
            trainOption = _uiService.TrainMenu();
        }
        if(trainOption == 1) // Video Training
        {
            List<VideoTraining> videoTrainings2 = _videoTrainingService.GetAllTraining();
            int trainingOptions = _uiService.TrainMenuItems(videoTrainings2);
            VideoTraining videoTraining = videoTrainings2[trainOption - 1];
            Console.WriteLine("You chose:");
            Console.WriteLine($"{videoTraining.Title}");
            Console.ReadLine();
        }
        else
        {
            List<LiveTraining> liveTrainings = _liveTrainingService.GetAllTraining();
            int trainingOptions = _uiService.TrainMenuItems(liveTrainings);
            LiveTraining liveTraining = liveTrainings[trainingOptions - 1];
            Console.WriteLine(liveTraining.Title);
            Console.WriteLine($"Trainer: {liveTraining.Trainer.FirstName} ");
            Console.ReadLine();
        }
        break;
    case "Upgrade to Premium":
        _uiService.UpgradetoPremiumInfo();
        _standardUserService.RemoveById(_currentUser.Id);
        _currentUser = _premiumUserService.Register(new PremiumUser()
        {
            FirstName = _currentUser.FirstName,
            LastName = _currentUser.LastName,
            Username = _currentUser.Username,
            Password = _currentUser.Password,
        });
        break;
    case "Reschedule training":
        List<LiveTraining> liveTrainingsForCurrentUser = _liveTrainingService.GetAllTraining()
            .Where(x => x.Trainer.Id == _currentUser.Id).ToList();
        if(liveTrainingsForCurrentUser.Count == 0)
        {
            Console.WriteLine("There are no live trainings!");
        }
        else
        {
            int trainingItem = _uiService.TrainMenuItems(liveTrainingsForCurrentUser);
            Console.WriteLine("Enter number of days");
            int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 10);
            _trainerService.GetById(_currentUser.Id)
                .RescheduleTraining(liveTrainingsForCurrentUser[trainingItem - 1], days);
        };
        break;
    case "Log Out":
        _currentUser = null;
        break;
    case "Account":
        int accountChoice = _uiService.AccountMenu();
        if(accountChoice == 1)
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            switch (_currentUser.Type)
            {
                case UserType.StandardUser:
                    _standardUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                    break;
                case UserType.PremiumUser:
                    _premiumUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                    break;
                case UserType.Trainer:
                    _trainerService.ChangeInfo(_currentUser.Id, firstName, lastName);
                    break;

            }
        }
        else
        {
            Console.WriteLine("Enter old password");
            string oldPassword = Console.ReadLine();
            Console.WriteLine("Enter new password");
            string newPassword = Console.ReadLine();
            switch(_currentUser.Type)
            {
                case UserType.StandardUser:
                    _standardUserService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                    break;
                case UserType.PremiumUser:
                    _premiumUserService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                    break;
                case UserType.Trainer:
                    _trainerService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                    break;
            }
        }
        break;


}

void Seed()
{
    _standardUserService.Register(new StandardUser()
    {
        FirstName = "Bob",
        LastName = "Bobsky",
        Username = "bob.bobsky",
        Password = "bob.bobsky1"
    });
    _premiumUserService.Register(new PremiumUser()
    {
        FirstName = "Anne",
        LastName = "Bobsky",
        Username = "anne.bobsky",
        Password = "anne.bobsky2"
    });
    Trainer paul = new Trainer()
    {
        FirstName = "Paul",
        LastName = "Paulsky",
        Username = "paul.paulsky",
        Password = "paul.paulsky3",
        YearsOfExperience = 3
    };
    Trainer registeredTrainer = _trainerService.Register(paul);
    _videoTrainingService.AddTraining(new VideoTraining()
    {
        Title = "Abs workout",
        Description = "Abs workout made easy",
        DifficultyLevel = TrainingDifficultyLevel.Easy,
        Link = "someLink",
        Rating = 3,
        //Time = 15.55
    });
    _videoTrainingService.AddTraining(new VideoTraining()
    {
        Title = "Cardio",
        Description = "Dance cardio",
        DifficultyLevel = TrainingDifficultyLevel.Medium,
        Link = "someLink",
        Rating = 5,
        //Time = 25
    });

    _liveTrainingService.AddTraining(new LiveTraining()
    {

        Title = "Cardio",
        Description = "Dance cardio",
        DifficultyLevel = TrainingDifficultyLevel.Medium,
        NextSession = DateTime.Now.AddDays(1),
        Trainer = registeredTrainer,
        Rating = 5,
        //Time = 25,
    });
}


//videoTrainingsDatabase.Insert(new VideoTraining
//{
//    Description = "Cardio training",
//    Duration = 360,
//    Title = "Cardio",
//    Rating = 4,
//    DifficultyLevel = TrainingDifficultyLevel.Medium
//});

//videoTrainingsDatabase.Insert(new VideoTraining
//{
//    Description = "Yoga training",
//    Duration = 200,
//    Title = "Yoga",
//    Rating = 4,
//    DifficultyLevel = TrainingDifficultyLevel.Medium
//});

//List<VideoTraining> videoTrainings = videoTrainingsDatabase.GetAll();

//videoTrainingsDatabase.Update(new VideoTraining
//{
//    Id = 2, // we must send the id in order to find the member of the collection that needs to be replaced
//    Description = "Yoga training updated",
//    Duration = 200,
//    Title = "Yoga 2",
//    Rating = 4,
//    DifficultyLevel = TrainingDifficultyLevel.Medium
//});

//VideoTraining yogaVideoTraining = videoTrainingsDatabase.GetById(2);
//Console.WriteLine(yogaVideoTraining.Description);

//videoTrainingsDatabase.DeleteById(1);
//videoTrainings = videoTrainingsDatabase.GetAll();

//Console.WriteLine("End");