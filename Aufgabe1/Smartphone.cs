using System;

namespace Aufgabe1
{

    class Smartphone
    {
        private int? pin=null;
        private int versuche=0;
        private bool authentifizieren()
        {
            if (versuche == 3)
            {
                Console.WriteLine("Authentifizierungsfehler");
                return false;
            }
            if (pin == null) return true;
            Console.WriteLine("Pin?");
            try
            { 
                do
                {
                    if (Int32.Parse(Console.ReadLine()) == pin)
                    {
                        versuche = 0;
                        return true;
                    }
                    else versuche++;
                } while (versuche < 3);
                Console.WriteLine("Authentifizierungsfehler");
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void PinAendern()
        {
            if (authentifizieren()==true)
            { 
                Console.WriteLine("neue Pin?");
                try
                {
                    string neu=Console.ReadLine();
                    if (neu.Equals(string.Empty))
                    {
                        pin = null;
                    }
                    else pin=Int32.Parse(neu);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            Smartphone phone = new Smartphone();
            phone.PinAendern();
            phone.PinAendern();
        }
    }
}
