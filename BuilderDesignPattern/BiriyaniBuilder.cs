using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class BiriyaniBuilder : IBiriyaniBuilder
    {
        private Biriyani biriyani;
        public BiriyaniBuilder()
        {
                biriyani = new Biriyani();
        }
        public BiriyaniBuilder AddBiriyaniType(string type)
        {
            this.biriyani.BiriyaniType = type;
            Console.WriteLine($"you have selected {type} biriyani");
            return this;
        }

        public BiriyaniBuilder AddPotato(int numberOfPotatos)
        {
            this.biriyani.Potato = numberOfPotatos;
            Console.WriteLine($"{numberOfPotatos} potato added");
            return this;
        }

        public BiriyaniBuilder OilyFood()
        {
            this.biriyani.Oily = true;
            Console.WriteLine($"oily food");
            return this;
        }

        public BiriyaniBuilder Spicy()
        {
            this.biriyani.Spicy = true;
            Console.WriteLine("Spicy food");
            return this;
        }

        public Biriyani GetBiriyani()
        {
            return biriyani;
        }

        
    }
}
