
//Extend the ShapeColourHelper static class so that it can make a shape a random colour from Yellow, Red, Blue, Green or Orange.
//using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class HwshapeColourHelper
    {

        public static Hwshape AddColour(Hwshape s)
        {
            s.Colour = "Yellow";

            return s;
        }

        public static Hwshape ChangeColour(Hwshape s)
        {
            s.Colour = "Orange";

            return s;
        }

    }
}