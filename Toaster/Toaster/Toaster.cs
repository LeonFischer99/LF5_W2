using System.Drawing;
using System.Text;

namespace LF5_LW3_MyFlyingToaster
{
    internal class Toaster
    {
        #region Properties
        private Color _Farbe;
        public Color Farbe { get; set; }

        public byte _Schaechte;
        public byte Schaechte { get; set; }

        private int _Toastzeit;
        public int Toastzeit { get; set; }

        private byte _ToastZustand;
        public byte ToastZustand { get; set; }

        private byte _ToastAnzahl;
        public byte ToastAnzahl { get; set; }
        #endregion Properties
        public Toaster(Color farbe, byte schaechte, int toastzeit, byte toastAnzahl)
        {
            this.Farbe = farbe;
            this.Schaechte = schaechte;
            this.Toastzeit = toastzeit;
            this.ToastAnzahl = toastAnzahl;
        }
        public Toaster(Color farbe, byte schaechte, int toastzeit)
        {
            this.Farbe = farbe;
            this.Schaechte = schaechte;
            this.Toastzeit = toastzeit;
        }

        public Toaster(Color farbe, byte schaechte)
        {
            this.Farbe = farbe;
            this.Schaechte = schaechte;
            this.Toastzeit = 30;
        }

        public void ToastReintun(byte toastAnzahl)
        {
            if ((this.Schaechte - this.ToastAnzahl) >= toastAnzahl)
            {
                this.ToastZustand = 0;
                this.ToastAnzahl = toastAnzahl;
                Console.WriteLine("Okay!");
            }
            else
            {
                Console.WriteLine("Nicht genug Platz");
            }
        }

        public void Toasten()
        {
            if (this.ToastAnzahl > 0)
            {
                Console.WriteLine("Toast-Vorgang wird gestartet.");
                for (int i = 0; i < Toastzeit; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Übrige Toastzeit: " + (Toastzeit - i));
                }
                ToastZustandErmitteln();
            }
            else
            {
                Console.WriteLine("Geht nicht, kein Toast drin.");
            }
        }

        private void ToastZustandErmitteln()
        {
            if (Toastzeit > 0 && Toastzeit <= 15)
            {
                ToastZustand = 1;
                Console.WriteLine("Der Toast ist leicht getoasted.");
            }
            else if (Toastzeit > 15 && Toastzeit <= 30)
            {
                ToastZustand = 2;
                Console.WriteLine("Der Toast ist stark getoasted.");
            }
            else if (Toastzeit > 30)
            {
                ToastZustand = 3;
                Console.WriteLine("Der Toast ist verbrannt.");
            }
        }

        public byte? ToastAuswerfen()
        {
            var temp = this.ToastAnzahl;
            this.ToastAnzahl = 0;
            return temp;
        }

        public override string ToString()
        {
            return new StringBuilder()
                .Append("Farbe: " + Farbe.ToString())
                .Append(" Schächte: " + Schaechte)
                .Append(" Toastzeit: " + Toastzeit)
                .Append(" Toastzustand: " + ToastZustand)
                .Append(" Toast Anzahl: " + ToastAnzahl).ToString();
        }
    }
}
