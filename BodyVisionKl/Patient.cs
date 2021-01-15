using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyVisionKl
{
    class Patient
    {
        private int id;
        private string identification;
        private string name; // field
        private string lastName;
        private int age;
        private string genre;
        private string birthDate;
        private string high;

        public int Id   
        {
            get { return id; }   
            set { id  = value; }  
        }

        public string Identification
        {
            get { return identification; }
            set { identification = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string High
        {
            get { return high; }
            set { high = value; }
        }
    }
}
