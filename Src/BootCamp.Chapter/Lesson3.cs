using System;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo()
        {
            PromptUserInfoAndCalculateBmi();
            PromptUserInfoAndCalculateBmi();
        }

        public static void PromptUserInfoAndCalculateBmi()
        {
            string name = PromptToString("Name: ");
            string surname = PromptToString("Surname: ");
            int age = PromptToInt("Age: ");
            float weight = PromptToFloat("Weight: ");
            float height = PromptToFloat("Height: ");

            float bmi = CalculateBmi(weight, height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is" +
                $"{weight} kg and his height is {height:N1} cm.");
            Console.WriteLine($"BMI: {bmi:N1}\n");
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }

        public static int PromptToInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static string PromptToString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static float PromptToFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }
    }
}