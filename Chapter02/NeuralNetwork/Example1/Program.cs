using Console = Colorful.Console;

namespace NeuralNetwork
{
    public class Program
    {
        static void Main(string[] args)
        {
            NNManager_8Apr2025 mgr = new NNManager_8Apr2025();
            mgr.SetupNetwork()
                .GetTrainingDataFromUser()
                .TrainNetworkToMinimum()
                .TestNetwork();

            Console.WriteLine("Press any key to train network for maximum");
            Console.ReadKey();

            mgr.SetupNetwork()
                .GetTrainingDataFromUser()
                .TrainNetworkToMaximum()
                .TestNetwork();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}
