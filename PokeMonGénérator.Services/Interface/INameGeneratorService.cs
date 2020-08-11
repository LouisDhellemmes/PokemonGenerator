using System;
using System.Collections.Generic;
using System.Text;

namespace PokeMonGénérator.Services.Interface
{
    interface INameGeneratorService
    {
        string GetById(int id);
        string GetRandom();
        List<string> GetSixRandom();
    }
}
