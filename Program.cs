namespace assigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            //////////////////////////////////////////////////////////////////
            ReverseArray.ReverseArrayMethod(numbers);
            Console.WriteLine($"reverse array :{string.Join(",",numbers)}");
            //////////////////////////////////////////////////////////////////
           int MaxNumber= FindMax.FindMaxMethod(numbers);
            Console.WriteLine($"max number is {MaxNumber}");
            
            
            
        }
    }
}
