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

public class Triangle {
    public Point point_a, point_b, point_c;
    public Triangle(Point point_a, Point point_b, Point point_c)
    {
        this.point_a = point_a;
        this.point_b = point_b;
        this.point_c = point_c;
    }

    public Point PointA
    {
        get { return point_a; }
        set { point_a = value; }
    }
    public Point PointB
    {
        get { return point_b; }
        set { point_b = value; }
    }
    public Point PointC
    {
        get { return point_c; }
        set { point_c = value; }
    }

    public void Print()
    {
        Console.WriteLine("Triangle with points: ({0}, {1}), ({2}, {3}), ({4}, {5})", PointA.x, PointA.y, PointB.x, PointB.y, PointC.x, PointC.y);
    }

    public double CalcPerimeter()
    {
        double perimeter = 0;
        perimeter = this.point_a.CalcDistance(this.point_b) + this.point_b.CalcDistance(point_c) + this.point_c.CalcDistance(point_a);
        return perimeter;
    }

    public double CalcSquare()
    {
        double square = 0;
        double halfPerimeter = this.CalcPerimeter() / 2;
        square = Math.Sqrt(halfPerimeter * (halfPerimeter - this.point_a.CalcDistance(this.point_b)) * (halfPerimeter - this.point_b.CalcDistance(this.point_c)) * (halfPerimeter - this.point_c.CalcDistance(this.point_a)));
        return square;
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
        
        Console.WriteLine("Input x and y coordinates for third point:");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        Point point3 = new Point(x, y);
        Triangle triangle = new Triangle(point1, point2, point3);
        triangle.Print();
        Console.WriteLine(triangle.CalcPerimeter());
        Console.WriteLine(triangle.CalcSquare());
    }
}