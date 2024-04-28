
using AbstractFactoryDesignPattern;

/*
 * Similar to factory design parrern. 
 * In factory design pattern , return type is void , bool or string etc
 * In Abstract Factory design pattern, return type is interface which will have multiple implementation depends on type
 * */


IFactory factory = new WoodenFactory();
var woodenChair = factory.CreateChair();
woodenChair.SitOn();

Console.ReadLine();
