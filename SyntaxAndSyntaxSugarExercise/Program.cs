namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Given Code
            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}

            // Modified Code
            var answer = 4; // inferred typing with var instead of int
            string response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine"; // ternary operator in conjunction with string interpolation
            Console.WriteLine(response);

        }
    }
}
