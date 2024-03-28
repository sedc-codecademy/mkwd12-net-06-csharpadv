using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.AbstractClasses.Interfaces
{
    //what ever class inherits from this interface will have to provide implementation for the Code method
    //or just contain the Code method signature, but will be marked as abstract
    public interface ISoftwareDeveloper
    {
        void Code();
    }
}
