using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanarkshireHillRace
{
    internal class Member
    {
        private int _id;
        private string _name;
        private int _age;
        private string _address;
        private string _postcode;
        private string _gender;

        public Member(int id, string name, int age, string address, string postcode, string gender)
        {
            Id = id;
            Name = name;
            Address = address;
            Postcode = postcode;
            Gender = gender;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Address { get => _address; set => _address = value; }
        public string Postcode { get => _postcode; set => _postcode = value; }
        public string Gender { get => _gender; set => _gender = value; }
    }
    class Senior : Member
    {
        private int _number;

        public Senior(int id, string name, int age, string address, string postcode, string gender, int number) : base(id, name, age, address, postcode, gender)
        {
            Number = number;
        }

        public int Number { get => _number; set => _number = value; }
    }
    class Junior : Member
    {
        private int _number;
        private string _guardian;

        public Junior(int id, string name,  int age, string address, string postcode, string gender, int number, string guardian) : base(id, name, age, address, postcode, gender)
        {
            Number = number;
            Guardian = guardian;
        }

        public int Number { get => _number; set => _number = value; }
        public string Guardian { get => _guardian; set => _guardian = value; }
    }
}
