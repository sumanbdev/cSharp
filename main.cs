using System;

namespace SonarQubeDemo
{
    public class CodeQualityDemo
    {
        // Unused variable example
        public void UnusedVariableExample()
        {
            int unusedValue = 42; // SonarQube: Remove this unused variable
            Console.WriteLine("This method has an unused variable.");
        }

        // Duplicate logic example
        public int AddNumbers(int a, int b)
        {
            // SonarQube: This logic is duplicated in AddNumbersDuplicate
            return a + b;
        }

        public int AddNumbersDuplicate(int x, int y)
        {
            // SonarQube: This logic is duplicated from AddNumbers
            return x + y;
        }

        // Potential null reference issue
        public void PrintStringLength(string input)
        {
            // SonarQube: Possible null reference exception if input is null
            Console.WriteLine("String length is: " + input.Length);
        }

        // Code smell: Long method and complex conditional
        public void ProcessData(int[] data)
        {
            // SonarQube: Method is too long and has complex conditionals
            if (data != null && data.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    sum += data[i];
                }
                double average = (double)sum / data.Length;
                Console.WriteLine("Average: " + average);

                if (average > 100)
                {
                    Console.WriteLine("High average");
                }
                else if (average > 50 && average <= 100)
                {
                    Console.WriteLine("Medium average");
                }
                else if (average > 0 && average <= 50)
                {
                    Console.WriteLine("Low average");
                }
                else
                {
                    Console.WriteLine("No data or negative average");
                }
            }
            else
            {
                Console.WriteLine("Data is null or empty");
            }
        }

        // Lack of XML comments on public method
        public void NoXmlCommentMethod()
        {
            // SonarQube: Add XML documentation to this public method
            Console.WriteLine("This method lacks XML comments.");
        }

        // Main method to run the demo
        public static void Main(string[] args)
        {
            var demo = new CodeQualityDemo();
            demo.UnusedVariableExample();
            Console.WriteLine("AddNumbers: " + demo.AddNumbers(2, 3));
            Console.WriteLine("AddNumbersDuplicate: " + demo.AddNumbersDuplicate(4, 5));
            demo.PrintStringLength(null); // Will throw exception (intentional for SonarQube)
            demo.ProcessData(new int[] { 10, 20, 30, 40, 50 });
            demo.NoXmlCommentMethod();
        }
    }
}