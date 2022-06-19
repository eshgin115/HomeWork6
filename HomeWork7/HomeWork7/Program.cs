using System;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Employee
    {
        public string _Name;
        public string _SurName;
        public string _FatherName;
        public string _Fin;
        public decimal _Number;
        public string _position;
        public int _Salary;
        public Employee(string Name, string SurName, string FatherName, string Fin, decimal Number, string position, int Salary)
        {
            _Name = Name;
            _SurName = SurName;
            _FatherName = FatherName;
            _Fin = Fin;
            _Number = Number;
            _position = position;
            _Salary = Salary;
        }
        static bool IsAlphabetical(string _name)
        {

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int k = 0; k < _name.Length; k++)
                {
                    if (alphabet[i] != _name[k])
                    {
                        Console.WriteLine(_name[k]);
                        Console.WriteLine($"{_name[k]}iwledmek olmaz");
                        return false;
                    }
                }
            }
            return true;
        }
        static bool IsLengthBwtween(string _name, int startLength, int endLength)
        {
            if (_name.Length < startLength || _name.Length > endLength)
            {
                Console.WriteLine("Daxil etdiyiniz indexin sayi 2 den cox 20 den az olmalidi");
                return false;
            }
            return true;

        }
        static bool IsCapital(char targetLettern, string _name)
        {
            char[] alphabetLower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < alphabetLower.Length; i++)
            {
                if (_name[0] == alphabetLower[i])
                {
                    Console.WriteLine(_name[0]);
                    return false;
                }
            }
            return true;
        }

        static bool IsValidFirstNmae(string firstName)
        {
            var IsValidFirstNmae = true;
            if (!IsAlphabetical(firstName))
            {
                IsValidFirstNmae = false;
            }
            if (!IsLengthBwtween(firstName, 2, 20))
            {
                IsValidFirstNmae = false;
            }
            if (!IsCapital(firstName[0]))
            {
                IsValidFirstNmae = false;
            }
            return IsValidFirstNmae;
        }

        static bool IsValidFirstSurNmae(string firstSurName)
        {
            var IsValidFirstSurNmae = true;
            if (!IsAlphabetical(firstSurName))
            {
                IsValidFirstSurNmae = false;
            }
            if (!IsLengthBwtween(firstSurName, 2, 35))
            {
                IsValidFirstSurNmae = false;
            }
            if (!IsCapital(firstSurName[0]))
            {
                IsValidFirstSurNmae = false;
            }
            return IsValidFirstSurNmae;
        }
        static bool IsValidFirstFatherName(string firstFatherName)
        {
            var IsValidFirstFatherNmae = true;
            if (!IsAlphabetical(firstFatherName))
            {
                IsValidFirstFatherNmae = false;
            }
            if (!IsLengthBwtween(firstFatherName, 2, 20))
            {
                IsValidFirstFatherNmae = false;
            }
            if (!IsCapital(firstFatherName[0]))
            {
                IsValidFirstFatherNmae = false;
            }
            return IsValidFirstFatherNmae;


        }
        static bool IsValidAge(int firstAge)
        {
            var IsValidAge = false;

            if (18 < firstAge && firstAge < 65)
            {
                IsValidAge = true;
            }
            return IsValidAge;

        }

    }
}

