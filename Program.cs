using DogDoorOOAD.Models;

namespace DogDoorOOAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor dogFrido=new DogDoor();
            Remote remote=new Remote(dogFrido);
            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("Fido went outside...");
            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e)
            {

            }
            Console.WriteLine("frido is stuck outside");
            Console.WriteLine("fido barks");
            remote.PressButton();
            Console.WriteLine("Fido is inside");


            Thread.Sleep(10000);

            Console.WriteLine();

            DogDoor Tex = new DogDoor();
            Remote remoteTex = new Remote(Tex);

            remoteTex.PressButton();
            Console.WriteLine("Tex goes outside");
            try
            {
                Thread.Sleep(7000);
            }
            catch (ThreadInterruptedException e)
            {

            }
            Console.WriteLine("Tex comes back");
            remoteTex.PressButton();


            Console.WriteLine();

            DogDoor dogBruce = new DogDoor();
            Remote remoteBruce = new Remote(dogBruce);
            ScratchSensor scratchSensor = new ScratchSensor(dogBruce);

            Console.WriteLine("Bruce scrateches");
            scratchSensor.ScratchDoor();
            Console.WriteLine("Bruce leaves home");

            Thread.Sleep(7000);
            Console.WriteLine();
            Console.WriteLine("Bruce scratches door again");
            scratchSensor.ScratchDoor();


            Thread.Sleep(6000);
            Console.WriteLine("Exiting the program...");

        }
    }
    
}
