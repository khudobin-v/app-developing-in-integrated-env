public class Point
{
    public int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public void Print()
    {
        Console.Write("X coordinate: ");
        Console.WriteLine(this.X);
        Console.Write("Y coordinate: ");
        Console.WriteLine(this.Y);
    }

    public double CalcDistance(Point targetPoint)
    {
        return Math.Sqrt(Math.Pow(targetPoint.X - this.X, 2) + Math.Pow(targetPoint.Y - this.Y, 2));
    }

    public void EditCoordinates(int NewX, int NewY)
    {
        this.X = NewX;
        this.Y = NewY;
        Console.WriteLine("New coordinates: ");
    }
   
}


class My
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input x and y coordinates for first point:");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Point point1 = new Point(x, y);

        Console.WriteLine("Input x and y coordinates for second point:");

        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        Point point2 = new Point(x, y);

        point1.Print();
        point2.Print();

        double distance = point1.CalcDistance(point2);
        Console.WriteLine(distance);

        Console.WriteLine("Input new x and y coordinates for second point:");

        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        point1.EditCoordinates(x, y);
        point1.Print();
    }
}