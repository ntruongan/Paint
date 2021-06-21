using System.Drawing;


namespace FeelUrPain
{
    static class ToDo
    {
        static public int min(int a, int b)
        {
            if (a > b)
                return b;
            else return a;
        }
        static public int max(int a, int b)
        {
            if (a > b)
                return a;
            else return b;
        }
        static public Point MinPoint(Point a, Point b)
        {
            return new Point(min(a.X, b.X), min(a.Y, b.Y));
        }
        static public Point MaxPoint(Point a, Point b)
        {
            return new Point(max(a.X, b.X), max(a.Y, b.Y));
        }
        static public Point AddPoint(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

    }
}
