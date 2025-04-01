//Create a new interface called IShape that is implemented by all shapes in the application. Add a method onto that called GetArea()
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Hwsquare : Hwshape, IShape
    {
        private int side;

        public Hwsquare(int s)
        {

            if (s > 10)
            {
                throw new Exception("Cannot be greater then 10");
            }

            side = s;
        }

        public Hwsquare() { }

        public void SetSide(int s)
        {
            side = s;
        }

        public override int GetArea()
        {
            return side * side;
        }

        public int GetArea()
        {
            throw new NotImplementedException();
        }

        public readonly int Sides;

    }
}