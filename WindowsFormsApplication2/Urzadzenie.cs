using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ivi.Visa.Interop;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class UrzadzenieUSB
    {
        public string Adres;

        public UrzadzenieUSB()
        {
        }

        public UrzadzenieUSB(string adres)
        {
            this.Adres = adres;
        }

        ~UrzadzenieUSB()
        {
            throw new System.NotImplementedException();
        }

        public void Wyslij(string arg)
        {
        }

        public string Odbierz()
        {
            return "Odezwała się klasa bazowa projektu :(";
        }

        public string Zmierz()
        {   
            return "Odezwała się klasa bazowa projektu :(";
        }
    
        public class DMM : UrzadzenieUSB
        {
            private Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            private Ivi.Visa.Interop.FormattedIO488 miernik = new Ivi.Visa.Interop.FormattedIO488();
                
            public DMM()
            {
                try
                {
                    miernik.IO = (IMessage)rm.Open(base.Adres, AccessMode.NO_LOCK, 2000, "");
                    miernik.IO.Timeout = 2000;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ~DMM()
            {
                        miernik.IO.Close();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(miernik);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(rm);
            }
        }
        
        public class Mikrokontroler : UrzadzenieUSB
        {
            int BaudRate;
            private System.IO.Ports.SerialPort serialPort;

            public Mikrokontroler()
            {
                this.serialPort.BaudRate = this.BaudRate;
                this.serialPort.PortName = base.Adres;
                this.serialPort.Open();
            }
            
            ~Mikrokontroler()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
