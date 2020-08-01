using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        
        public static string AskInformation()
        {
            Console.WriteLine("Testing");
            string firstName = Console.ReadLine();
            string errorMsg = "Name cannot be empty.";

            if (String.IsNullOrEmpty(firstName))
            {
                Console.WriteLine(errorMsg);
                return errorMsg;
            }
            else
            {
                return firstName;
            }
        }

        public static int AskAge()
        {
            Console.WriteLine("Testing");
            string sAge = Console.ReadLine();

            int age;
            bool isNumber = int.TryParse(sAge, out age);

            if (!isNumber) return -1;
            if (age == 0) return 0;
            if (age >= 0) return age;

            return 0;

        }

        public static float Weight = 0f;
        public static float AskWeight()
        {
            Console.WriteLine("What is your weight in kgs?");
            string sWeight = Console.ReadLine();

            bool isNumber = float.TryParse(sWeight, out Weight);

            if (!isNumber)
                {
                    Console.WriteLine(Weight + " is not a valid number.");    
                    return -1; 
                }
            if (Weight == 0) return 0;
            if (Weight >= 0) return Weight;

            return 0;
        }

        public static float Height = 0f;
        public static float AskHeight()
        {
            Console.WriteLine("Testing");
            string sHeight = Console.ReadLine();

            bool isNumber = float.TryParse(sHeight, out Height);

            if (!isNumber)
            {
                Console.WriteLine("\"" + sHeight + "\"" + " is not a valid number.");
                return -1;
            }
            if (Height == 0) return 0;
            if (Height >= 0) return Height;

            return 0;
        }

       

        public static float BMIFormula(float weight, float height)
        {
            string bmiError = "Failed calculating BMI. Reason:";

            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine(bmiError + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;

            }
            if (weight <= 0 )
            {
                Console.WriteLine(bmiError + Environment.NewLine +  "Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }

            if (height <= 0)
            {
                Console.WriteLine(bmiError + Environment.NewLine + "Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }

            else
            {
                float bmiValue = weight / height / height;
                return bmiValue;
            }

        }

        public static void Message()
        {
            Console.WriteLine(Lesson4.AskInformation() + " is " + Lesson4.AskAge() + " years old, their weight in kg is " + Lesson4.AskWeight()
            + " and their height in cm is " + Lesson4.AskHeight() + ". " + "Their BMI is " + Lesson4.BMIFormula(Weight, Height));
        }
    }
}
