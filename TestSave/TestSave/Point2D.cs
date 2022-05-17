namespace TestSave;
[Serializable]
public class Point2D
{
    public int x { get; set; }
    public int y { get; set; }

    public string color { get; set; }

    public Point2D()
    {
        x = -1;
        y = -1;
        color = "Default";
    }

    public Point2D(int _x, int _y, string _color)
    {
        x = _x;
        y = _y;
        color = _color;
    }

    public void Print()
    {
        Console.WriteLine("x:" + x + "   y:" + y + "     color:" + color);
    }

    public void changeColor(String _color)
    {
        color = _color;
    }
}
