using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanarkshireHillRace
{
    internal class Library
    {
        private List<Member> _members;
        private List<Senior> _seniors;
        private List<Junior> _juniors;

        public Library()
        {
            _members = new List<Member>();
            _seniors = new List<Senior>();
            _juniors = new List<Junior>();
        }

        public List<Member> Members { get { return _members; } }
        public List<Senior> Seniors { get { return _seniors; } }
        private List<Junior> Juniors { get { return _juniors; } }

        public void AddMember(string name, int age, string address, string postcode, string gender)
        {
            int id = _members.Count + 1;
            Member m = new Member(id, name, age, address, postcode, gender);
            Members.Add(m);

        }
        public void AddSenior(string name, int age, string address, string postcode, string gender, int number) 
        {
            int id = _seniors.Count + 1;
            Senior s = new Senior(id,name,age,address,postcode,gender,number);
            Seniors.Add(s);

        }
        public void AddJunior(string name, int age, string address, string postcode, string gender, int number, string guardian) 
        { 
            int id = Juniors.Count + 1;
            Junior j = new Junior(id, name, age, address, postcode, gender, number, guardian);
            Juniors.Add(j);
        }

        public void ListMember()
        {
            foreach(Member m in Members)
            {
                MessageBox.Show("Member: " + m.Name);
            }
        }

        public void ListSenior()
        {
            foreach (Senior s in _seniors)
            {
                MessageBox.Show("Member: " + s.Name);
            }
        }

        public void ListJunior()
        {
            foreach (Junior j in _juniors)
            {
                MessageBox.Show("Member: " + j.Name);
            }
        }
    }
}
