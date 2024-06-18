// See https://aka.ms/new-console-template for more information
using Geometry;
var figure =  new  List <IFigure> 
{
    new Quadrato(3),
    new Quadrato(4),
    new Rettangolo(5,5)
};
foreach (var item in figure)
{
   Console.WriteLine($"{item.Message()}") ;
}