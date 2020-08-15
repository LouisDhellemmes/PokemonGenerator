using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.IO;

namespace PokeMonGénérator.Services
{
    public class NatureGeneratorService
    {
        public string nature;
        public string GetById(int id){
            string text = File.ReadAllText("../../../../BD/nature.txt");
            string[] listNature = text.Split(' ');
            Console.WriteLine(listNature);
            return nature = listNature[id*3];
        }
        public string GetRandom(){
            int randInt;
            Random rand = new Random();
            randInt = rand.Next(1, 25);
            nature = GetById(randInt);
            return nature;
        }
    }
}
