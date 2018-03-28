namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int number)
        {
            if(IsDivisableBy3(number) && IsDivisableBy5(number))
            {
                return "FizzBuzz";
            }
            else if(IsDivisableBy3(number))
            {
                return "Fizz";
            }
            else if(IsDivisableBy5(number))
            {
                return "Buzz";
            }
            
            return number.ToString();
        }

        private bool IsDivisableBy5(int number)
        {
            return number % 5 == 0;
        }

        private bool IsDivisableBy3(int number)
        {
            return number % 3 == 0;
        }
    }
}