namespace EnhancedIfStatements
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            Console.WriteLine("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if(validInteger)
            {
                temperatureMessage = inputTemperature <= 15 ? "It is too cold here" : (inputTemperature >= 16 && inputTemperature <= 28) ? "It is ok here" : inputTemperature > 28 ? "It is hot here" : "";
                Console.WriteLine(temperatureMessage);
            }else
            {
                Console.WriteLine("Not a valid temperature");
            }
        }

        
    }
}