using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_WinFromsControlElements_
{
    public class CrewMember
    {
        public string name = "";
        public int age = 0;
        public int ageExp = 0;
        positionOfMember position=positionOfMember.none;
        public enum positionOfMember{pilot, stewardess,none};
        

        public CrewMember(string name, int age, int ageExp, positionOfMember position)
        {
            this.name = name;
            this.age = age;
            this.ageExp = ageExp;
            this.position = position;
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Years of Experience: {ageExp}, Position: {position}";
        }

    }
}
