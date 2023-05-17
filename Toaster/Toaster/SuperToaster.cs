using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF5_LW3_MyFlyingToaster
{
    internal class SuperToaster : Toaster
    {
        private double _Temperatur;
        public double Temperatur { 
            get 
            { 
                return _Temperatur; 
            } 
            set 
            { 
                if(value > 500)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    _Temperatur = value;
                }
            }
        }
        public SuperToaster(Color farbe, byte schaechte, int toastzeit) : base(farbe, schaechte, toastzeit) 
        {
            this.Temperatur = 20;
        }

        public SuperToaster(Color farbe, byte schaechte, int toastzeit, byte toastAnzahl) : base(farbe, schaechte, toastzeit, toastAnzahl)
        {
            this.Temperatur = 20;
        }

        public SuperToaster(Color farbe, byte schaechte) : base(farbe, schaechte) 
        {
            this.Temperatur = 20;
        }

        public void TemperaturErhoehen(int newTemp)
        {
            this.Temperatur += newTemp;
        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString()).Append(" Tempteratur: " + Temperatur).ToString();
        }



    }
}
