namespace Geometry
{
    public abstract class Figure : IFigure
    {
        public double Lato {get; set;}
    public Figure(double lato)
    {
     Lato = lato;   
    }
    public abstract double Perimetro();
    public abstract double Area();
    public virtual string Message()
    {
        var perimetro = Perimetro();
        var area = Area();
        return  "questo è il lato: " + Lato + $", questo è il perimetro : {perimetro} e questa è l' Area : {area} "; 
    }
    }
}