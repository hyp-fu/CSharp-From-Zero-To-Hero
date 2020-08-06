using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        
        public static string PromptString()
        {
            Console.WriteLine("Testing");
            string name = Console.ReadLine();
            string errorMsg = "Name cannot be empty.";

            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine(errorMsg);
                return "-";
            }
            else
            {
                return name;
            }
        }

        public static int PromptInt()
        {
            Console.WriteLine("Testing");
            string stringInt = Console.ReadLine();

            int convertedInt;
            bool isNumber = int.TryParse(stringInt, out convertedInt);

            if (String.IsNullOrEmpty(stringInt))
            {
                return 0;
            }
            if (!isNumber)
            {
                Console.WriteLine("\"" + stringInt + "\"" + " is not a valid number.");
                return -1;
            }
            if (convertedInt == 0) return 0;
            if (convertedInt >= 0) return convertedInt;

            return 0;

        }

        public static float PromptFloat()
        {
            Console.WriteLine("Testing");
            string stringFloat = Console.ReadLine();

            float convertedFloat;

            bool isNumber = float.TryParse(stringFloat, out convertedFloat);

            if (String.IsNullOrEmpty(stringFloat))
            {
                return 0;
            }
            if (!isNumber)
                {
                    Console.WriteLine("\"" + stringFloat + "\"" + " is not a valid number.");    
                    return -1; 
                }
            if (convertedFloat == 0) return 0;
            if (convertedFloat >= 0) return convertedFloat;

            return 0;
        }

        public static float PromptBmi(float weight, float height)
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
            string name = PromptString();
            int age = PromptInt();
            float weight = PromptFloat();
            float height = PromptFloat();
            float bmi = PromptBmi(weight, height);

            Console.WriteLine(name + " is " + age + " years old, they weigh " + weight + " kgs, are " + height + " cms tall, and their bmi is " + bmi + ".");

        }
    }
}
