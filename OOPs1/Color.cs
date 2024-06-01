public class Color
{
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    // Constructor 
    public Color(int red, int green, int blue, int alpha)
    {
        this._red = red;
        this._green = green;
        this._blue = blue;
        this._alpha = alpha;
    }

    // Constructor for colours defaulting to 255
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    // Methods to get and set red, green, blue, and alpha values
    public int Red
    {
        get { return _red; }
        set { _red = value; }
    }

    public int Green
    {
        get { return _green; }
        set { _green = value; }
    }

    public int Blue
    {
        get { return _blue; }
        set { _blue = value; }
    }

    public int Alpha
    {
        get { return _alpha; }
        set { _alpha = value; }
    }

    // Method to get the gray scales value
    public int GetGrayscale()
    {
        return (_red + _green + _blue) / 3;
    }
}