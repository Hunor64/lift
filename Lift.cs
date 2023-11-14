using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LiftWPF
{
    class Lift
    {
        string datum;
        int kartyaSorszam;
        int induloSzint;
        int celSzin;
        public Lift(string inputLine) 
        {
            var inputList = inputLine.Split(' ');
            this.datum = inputList[0];
            this.kartyaSorszam = int.Parse(inputList[1]);
            this.induloSzint = int.Parse(inputList[2]);
            this.celSzin = int.Parse(inputList[3]);
        }
    }
}
