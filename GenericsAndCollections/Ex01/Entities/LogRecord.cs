using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndCollections.Ex01.Entities
{
    class LogRecord
    {
        public string Name { get; set; }
        public DateTime AccessDate { get; set; }

        public LogRecord(string name, DateTime accessDate)
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
            if(!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = obj as LogRecord;
            return Name.Equals(other.Name);
        }
    }
}
