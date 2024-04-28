using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IBiriyaniBuilder
    {
        BiriyaniBuilder AddBiriyaniType(string type);

        BiriyaniBuilder Spicy();

        BiriyaniBuilder OilyFood();

        BiriyaniBuilder AddPotato(int numberOfPotatos);

        Biriyani GetBiriyani();
    }
}
