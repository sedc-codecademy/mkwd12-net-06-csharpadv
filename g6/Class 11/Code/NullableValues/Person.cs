using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableValues
{
    public class Person
    {
        public int Id { get; set; } //default 0

        //nullable int as type, Score has default value null
        //Score can get any whole number as a value, but it can also get null as value
        public int? Score { get; set; }

        public bool IsStudent { get; set; } //default value false

        //IsEmployed can get true, false and null as value
        public bool? IsEmployed { get; set; } //default value is null

        public string Name { get; set; } //default is null

        public List<int> Numbers { get; set; } //default null, because it is a reference type - we need to vreate an empty list in the constructor if we want to do sth with the list
    }
}
