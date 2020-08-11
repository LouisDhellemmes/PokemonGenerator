using System;
using System.Collections.Generic;
using System.Text;

namespace PokeMonGénérator.Services.Interface
{
    public interface INatureGeneratorService
    {
        string GetById(int id);
        string GetRandom();
    }
}
