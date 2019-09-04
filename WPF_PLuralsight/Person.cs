using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_PLuralsight
{
    public class Person
    {
        // must use properties
        public string Name { get; set; }
        public string Title { get; set; }

        public static Person GetPerson()
        {
            var ak = new Person()
            {
                Name = "Akhilesh Kumar",
                Title= "Teacher"
            };
            return ak;
        }
    }
}
