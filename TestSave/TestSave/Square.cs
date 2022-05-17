namespace TestSave;

public class Square
{

    public List<Point2D> points { get; set; }

    public void PrintFull()
    {
        for (int i = 0; i < points.Count; i++)
        {
            points[i].Print();
        }
    }

    public void changeColor(String _color, int i)
    {
        points[i].changeColor(_color);
    }

    public Square()
    {
        points = new List<Point2D>();
    }

    public Square(List<Point2D> _points)
    {
        points = _points;
    }

    public void AddPoint(Point2D point)
    {
        points.Add(point);
    }
}
