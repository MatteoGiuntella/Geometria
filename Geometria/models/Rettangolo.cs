namespace Geometry
{
    public class Rettangolo : Figure
    {
        public static double Base { get; set; }
        public Rettangolo(double bases, double lato) : base(lato)
        {
            Base = bases;
        }
        public override double Perimetro()
        {
            var perimetro = (Base * 2) + (Lato * 2);
            return perimetro;
        }
        public override double Area()
        {
            var area = Base * Lato;
            return area;
        }
        public override string Message()
        {  
         
            return base.Message() + $"la base {Base} + e questa è l' altezza {Lato}";

        }
    }
}