using System;
using System.Collections.Generic;
using System.Text;

namespace PokeMonGénérator.Services.Interface
{
    interface IAttackGeneratorService
    {
        string GetById(int id);
        string GetOneRandom();
        List<string> GetFourRandom();
        string GetOneRandomByType(string type);
        List<string> GetFourRandomByType(string type);

    }
}
