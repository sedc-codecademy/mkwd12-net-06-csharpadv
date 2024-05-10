using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    //UI -> user interface
    public interface IUIService
    {
        //Users can only register as a standard users
        StandardUser FillRegisterData();

        string MainMenu(UserRoleEnum userRole);
    }
}
