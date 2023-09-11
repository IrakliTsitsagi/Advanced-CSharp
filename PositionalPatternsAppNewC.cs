namespace PositionalPatternsAppNewC
{

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }
    internal class PositionalPatternsAppNewC
    {
        static void Main(string[] args)
        {
            Point startPoint = new Point(0, 0);
            Console.WriteLine(DisplayPosition(startPoint));
            Point point = new Point(100, 150);
            Console.WriteLine(DisplayPosition(point));
        }

        static string DisplayPosition(Point point) =>
            point switch
            {
                (0, 0) => "Origin",
                var (x, y) when x > 0 && y > 0 => $"Current position is {x}, {y}",
                _ => "unknown position" // _=> es nishnavs defaults
            };
    }
}