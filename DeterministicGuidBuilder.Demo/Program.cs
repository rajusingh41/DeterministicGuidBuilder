namespace DeterministicGuidBuilder.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Jone joe";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(DeterministicGuidBuilder.GuidBuilder.Create(name));
            }
            
        }
    }
}
