using System;
using System.Collections.Generic;
using System.Text;

namespace PokeMonGénérator.Services.Interface
{
    public interface ITalentGeneratorService
    {
        string GetById(int id);
        string GetRandom(int id);
    }
}
