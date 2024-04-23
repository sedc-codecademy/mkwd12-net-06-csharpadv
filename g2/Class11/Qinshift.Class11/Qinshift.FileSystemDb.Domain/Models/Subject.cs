using Qinshift.FileSystemDb.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.FileSystemDb.Domain.Models
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public int Classes { get; set; }
        public Academy Academy { get; set; }

        public Subject(string title, int classes, Academy academy)
        {
            Title = title;
            Classes = classes;
            Academy = academy;
        }

        public override string Info()
        {
            return $"{Title} from the {Academy} lasts for {Classes} classes!";
        }
    }
}
