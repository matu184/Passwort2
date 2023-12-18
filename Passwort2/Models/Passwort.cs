using System.Text;

namespace Passwort2.Models
{
    public class Passwort
    {
        //// mehrere
        //public int Anzahl { get; set; } = 1;
        ////
        public int Länge { get; set; } = 8;
        public int Buchstaben { get; set; } = 1;
        public int Zahlen { get; set; } = 1;
        public int Sonderzeichen { get; set; } = 1;


        public string PasswortGenerator()
        {
            string gross = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string klein = "abcdefghijklmnopqrstuvwxyz";
            string zahlen = "0123456789";
            string sonderzeichen = "!§$%&/()=?*+#-_.:,;<>|";
            if (Länge < Buchstaben + Zahlen + Sonderzeichen)
            {
                return "Die Länge des Passworts ist zu kurz";
            }

            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            //while (Anzahl > 0)
            //{

                for (int i = 0; i < Buchstaben; i++)
                {
                    stringBuilder.Append(gross[random.Next(gross.Length)]);
                }
                for (int i = 0; i < Zahlen; i++)
                {
                    stringBuilder.Append(zahlen[random.Next(zahlen.Length)]);
                }
                for (int i = 0; i < Sonderzeichen; i++)
                {
                    stringBuilder.Append(sonderzeichen[random.Next(sonderzeichen.Length)]);
                }
                int Rest = Länge - Buchstaben - Zahlen - Sonderzeichen;
                for (int i = 0; i < Rest; i++)
                {
                    stringBuilder.Append(klein[random.Next(klein.Length)]);
                }
            //    Anzahl--;
            //}
            string passwort = new string(stringBuilder.ToString().ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());

            return passwort;
        }
    }
}


