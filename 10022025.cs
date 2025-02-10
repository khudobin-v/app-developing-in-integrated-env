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
    public class Side
    {
        public Point point_a, point_b;
        public Side(Point point_a, Point point_b)
        {
            this.point_a = point_a;
            this.point_b = point_b;
        }
        public double CalcSide()
        {
            return this.point_a.CalcDistance(this.point_b);
        }
    }

    public Side side_ab, side_ac, side_bc;
    public Triangle(Point point_a, Point point_b, Point point_c)
    {
        side_ab = new Side(point_a, point_b);     
        side_bc = new Side(point_b, point_c);     
        side_ac = new Side(point_a, point_c);     
    }



    public double CalcPerimeter()
    {
        double perimeter = 0;
        perimeter = side_ab.CalcSide() + side_ac.CalcSide() + side_bc.CalcSide();
        return perimeter;
    }

    public double CalcSquare()
    {
        double square = 0;
        double halfPerimeter = this.CalcPerimeter() / 2;
        square = Math.Sqrt(halfPerimeter * (halfPerimeter - side_ab.CalcSide()) * (halfPerimeter - side_bc.CalcSide()) * (halfPerimeter - side_ac.CalcSide()));
        return square;
    }

    public void Print()
    {
        Console.WriteLine("Triangle's perimeter: {0}", this.CalcPerimeter());
        Console.WriteLine("Triangle's square: {0}", this.CalcSquare());
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
    }
}