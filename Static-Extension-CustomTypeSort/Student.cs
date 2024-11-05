using System;
namespace Static_Extension_CustomTypeSort
{
    public class Student
    {
        private string _fullName;
        private string _groupNo;
        private byte _age;

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CorrectGroupNo(value))
                {
                    _groupNo = value;
                }
                else
                    Console.WriteLine("GroupNo is incorrect");
            }
        }

        private string ValidName(string name, string surname)
        {
            if (string.IsNullOrWhiteSpace(name) || (string.IsNullOrWhiteSpace(surname)))
            {
                return "Name or Surname must be added";
            }
            if (CorrectFullName(name) && CorrectFullName(surname))
            {
                return Capitalize(name) + " " + Capitalize(surname);
            }
            return "Name or Surname is incorrect";



        }

        // GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural ededed ibaret olmalidir
        private static bool CorrectGroupNo(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 4)
                return false;
            return (char.IsUpper(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]));

        }

        // Fullname memberi ad ve soyadi ifade edir,ona gore de fullname value-u ad ve soyaddan ibaret olmalidir.Formati ad +bosluq+soyad seklinde olmalidir

        private static bool CorrectFullName(string input)
        {
            foreach (char c in input)
                if (char.IsLetter(c))
                {
                    return true;
                }
            return false;
        }

        private static string Capitalize(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }



    }
}


