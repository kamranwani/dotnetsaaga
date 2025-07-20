namespace ProjectTwo
{
    public class AreaAndPerimeter
    {
        public static float CalArea(in float length, in float width)
        {
            return (length * width);
        }
        public static float CalPerimeter(in float length, in float width)
        {
            return 2 * (length + width);
        }

    }
    internal class AreaAndPerimeter2
    {
        public static void DisplayMsg()
        {
            Console.WriteLine("internal class proj 2")
        }
       

    }
}
