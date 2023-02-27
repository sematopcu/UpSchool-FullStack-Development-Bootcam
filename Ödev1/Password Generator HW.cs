// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplePasswordGenerator.UpSchool
{
    public class SPGenerator
    {
        private readonly static Random _rand = new Random();
        private static bool includelower;
        private static bool includeUppercase;
        private static bool includenumber;


        const string lower= "abcdefghijklmnopqrstuvwxyz";
        const string upper= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string number = "0123456789";
        const string special = "!@#$%^&*_-=+";

        public static string SelectedChars { get; set; } = null!;
        public SPGenerator()
        {
            Random _rand = new Random();
        }
        public static void SelectNumbers()
        {
            SelectedChars += (number);
        }
        public static void SelectLetters()
        {
            SelectedChars += (lower);
        }
        public static void SelectLettersUpper()
        {
            SelectedChars += (upper);
        }
        public static void SelectSpecialChars()

        {
            SelectedChars += (special);
            {
                Console.WriteLine("Do you want to include numbercase ?");
                string Lowercase = Console.ReadLine();
            }
            switch (lower)
            {
                case "Y":
                    SPGenerator.SelectLetters(); break;
                case "y":
                    SPGenerator.SelectLetters(); break;
                    
            }
            Console.WriteLine("OK! How about lowercase characters?");
            string Uppercase = Console.ReadLine();
            switch (Uppercase)
            {
                case "Y":
                    SPGenerator.SelectLettersUpper(); break;
                case "y":
                    SPGenerator.SelectLettersUpper(); break;
                   
            }
            Console.WriteLine("Very Nice! How about uppercase characters? ");
            string Numbercase = Console.ReadLine();
            switch (Numbercase)
            {
                case "Y":
                    SPGenerator.SelectNumbers(); break;
                case "y":
                    SPGenerator.SelectNumbers(); break;
            }
            Console.WriteLine("All Right! We are almost done. Would you also want to add specialcase characters? ? ");
            string Specialcase = Console.ReadLine();
            switch (Specialcase)
            {
                case "Y":
                    SPGenerator.SelectSpecialCase(); break;
                case "y":
                    SPGenerator.SelectSpecialCase(); break;
            }



            Console.WriteLine("Great! How long do you want to keep your password length?");
                int passwordLength = Convert.ToInt32(Console.ReadLine());
        }

        private static void SelectSpecialCase()
        {
            throw new NotImplementedException();
        }
       
    }
    
}
