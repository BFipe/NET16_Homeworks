using System;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phoneSelecting = 0;
            string nameCalling;
            bool phoneSelectingOperation = false;
            Phone phoneInfo1 = new Phone("8 (800) 555-35-35", "Motorolla", 265);
            Phone phoneInfo2 = new Phone("8 (029) 253-23-32", "Nokia", 1512);
            Phone phoneInfo3 = new Phone("8 (017) 213-13-12", "Pager", -256);

            Console.WriteLine("Select the phone you want to ring from (1-3): ");

            while (phoneSelectingOperation == false || (phoneSelecting < 1 || phoneSelecting > 3))
            {
                phoneSelectingOperation = int.TryParse(Console.ReadLine(), out phoneSelecting);
          
            }

            Console.WriteLine("enter the name of your contact");
            nameCalling = Console.ReadLine();

            switch (phoneSelecting)
            {
                case 1:
                    phoneInfo1.RecieveCall(nameCalling);
                    break;
                case 2:
                    phoneInfo2.RecieveCall(nameCalling);
                    break;
                case 3:
                    phoneInfo3.RecieveCall(nameCalling);
                    break;
                default:
                    break;
            }

        }
    }
}
