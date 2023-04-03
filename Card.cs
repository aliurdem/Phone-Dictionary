using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory
{
    internal class Card : IComparable<Card>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }

        public Card(string name, string surName, string phoneNumber)
        {
            Name = name;
            SurName = surName;
            PhoneNumber = phoneNumber;
        }

        public int CompareTo(Card? other)
        {
            return string.Compare(Name, other.Name);
        }

        public void showInfo() {
            Console.WriteLine($"\n--------------" +
                              $"\nName : {this.Name}" +
                              $"\nSurname : {this.SurName}" +
                              $"\nPhone Number : {this.PhoneNumber}" +
                              $"\n--------------\n");
        }
    }
}
