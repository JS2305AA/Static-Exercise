namespace StaticExercise
{
    public class Program //Do I need to put this to static?
    {
        
        static void Main(string[] args)
        {
            var celcius = TempConverter.FarenheitToCelcius(68); //20

            var farenheit = TempConverter.CelciusToFarenheit(20); //68

            Console.WriteLine("After Conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"farenheit {farenheit}");
                                                                

        }
    }
}
