// See https://aka.ms/new-console-template for more information


using BuilderDesignPattern;

IBiriyaniBuilder biriyaniBuilder = new BiriyaniBuilder();
biriyaniBuilder.AddBiriyaniType("chicken").AddPotato(2);

Console.WriteLine($"{biriyaniBuilder.GetBiriyani().BiriyaniType} biriyani is ready");
