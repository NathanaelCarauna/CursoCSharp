using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndCollections.Ex01.Entities
{
    class User
    {
        public string Name { get; set; }
        public DateTime AccessDate { get; set; }

        public User(string name, DateTime accessDate)
        {
            Name = name;
            AccessDate = accessDate;
        }

        public override string ToString()
        {
            return Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is User))
            {
                return false;
            }
            User other = obj as User;
            return Name.Equals(other.Name);
        }
    }
}
