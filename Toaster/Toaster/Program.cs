using System.Drawing;

namespace LF5_LW3_MyFlyingToaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kleine Demonstration der Funktionsweise
            Toaster t1 = new Toaster(Color.FromArgb(255, 0, 0), 2, 7);
            Console.WriteLine(t1.ToString());
            SuperToaster t2 = new SuperToaster(Color.FromArgb(0, 255, 0), 4, 24);
            Console.WriteLine(t2.ToString());
            t1.ToastReintun(2);
            t1.Toasten();
            Console.WriteLine(t1.ToString());
            t2.TemperaturErhoehen(400);
            Console.WriteLine(t2.ToString());
            t2.Toastzeit = 17;
            t2.ToastReintun(3);
            t2.Toasten();
            Console.WriteLine(t2.ToString());


        }
    }
}