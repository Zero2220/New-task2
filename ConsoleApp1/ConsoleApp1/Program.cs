using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fullName;
            do
            {
                Console.WriteLine("adi ve soyadi daxil edin ");
                fullName = Console.ReadLine();

            }
            while (!checkFullName(fullName));

            string GroupName;
            do
            {
                Console.WriteLine("group nomresini daxil edin ");
                GroupName = Console.ReadLine();

            }
            while (!checkGroupName(GroupName));
            int age;
            string agestr;
            do
            {
                Console.WriteLine("yasi daxil edin ");
                agestr = Console.ReadLine();

            }
            while (!int.TryParse(agestr,out age));

            Student student = new Student(fullName,GroupName,age);
            

            Console.WriteLine(student.Fullname);
            Console.WriteLine(student.GroupNo);
            Console.WriteLine(student.Age);



        }


        static bool checkFullName(string fullName)
        {
            bool result;
            fullName.Trim();

            int count = fullName.Length - fullName.Replace(" ", "").Length;

            if (fullName != null && count == 1 && fullName.Length >= 8)
            {
                result = true;


            }
            else result = false;

            return result;


        }

        static bool checkGroupName(string groupName)
        {

            groupName.Trim();
            
            string  groupName1 = groupName.ToLower();
            string  groupName2 = groupName1.ToUpper();


            if (groupName != null && groupName.Length == 4 && char.IsLetter(groupName1, 0) && char.IsLetter(groupName2, 0))
            {
                return true;
            }
            else return false;


        }
    }
}
