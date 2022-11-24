namespace DPStateProject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new(new FileLogger());
            logger.LogWrite();

            logger.State = new ConsoleLogger();
            logger.LogWrite();
        }
    }
}