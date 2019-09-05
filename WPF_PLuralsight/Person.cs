using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WPF_PLuralsight
{
    public class Person : INotifyPropertyChanged
    {
        // must use properties
        private string name;
        public string Name { get { return name; } set { name = value; OnPropertyChanged(); } }

        private string title;
        public string Title { get { return title; } set { title = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public static Person GetPerson()
        {
            var ak = new Person()
            {
                Name = "Akhilesh Kumar",
                Title = "Teacher"
            };
            return ak;
        }

        public static ObservableCollection<Person> GetPersons()
        {
            var persons = new ObservableCollection<Person>();
            persons.Add(new Person() { Name = "Akhilesh" , Title = "DevOps" });
            persons.Add(new Person() { Name = "Akhilesh", Title = "DevOps" });
            persons.Add(new Person() { Name = "Akhilesh", Title = "DevOps" });
            persons.Add(new Person() { Name = "Akhilesh", Title = "DevOps" });
            persons.Add(new Person() { Name = "Akhilesh", Title = "DevOps" });

            return persons;
        }
    }
}
