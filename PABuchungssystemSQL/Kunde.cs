using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABuchungssystemSQL
{
    public class Kunde
    {
        public int Kundennr { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Strasse { get; set; }
        public int Hausnr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }


        public string FullInfo 
        {
            get
            {
                return $" { Kundennr } { Nachname } { Email } { Telefon }";
            } 
        }
    }
}
