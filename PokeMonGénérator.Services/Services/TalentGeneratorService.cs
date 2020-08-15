using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PokeMonGénérator.Services
{
    public class TalentGeneratorService
    {
        public string talent;
        public string GetById(int id)
        {
            string text = File.ReadAllText("../../../../BD/talent.txt");
            string[] listNature = text.Split(' ');

            return talent = listNature[id];
        }

        public string GetRandom()
        {
            int randInt;
            Random rand = new Random();

            randInt = rand.Next(0, 260);
            talent = GetById(randInt);
            return talent;
        }
    }
}
