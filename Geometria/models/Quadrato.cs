namespace Geometry
{
    public class Quadrato : Figure
    {


        public Quadrato(double lato) : base(lato)
        {
          
        }
        public override double Perimetro()
        {
            var perimetro = Lato * 4;
            return perimetro;
        }
         public override double Area()
        {
            var area = Lato * Lato;
            return area;
        }
        
    }
}