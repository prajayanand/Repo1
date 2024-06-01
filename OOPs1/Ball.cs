public class Ball
{
    private int _size;
    private Color _color;
    private int _throwCount;

    // Constructor with size and color
    public Ball(int size, Color color)
    {
        this._size = size;
        this._color = color;
        this._throwCount = 0;
    }

    // Method to pop the ball
    public void Pop()
    {
        _size = 0;
    }

    // Method to throw the ball, only if it hasn't been popped
    public void Throw()
    {
        if (_size > 0)
        {
            _throwCount++;
        }
    }

    // Method to get the throw count
    public int GetThrowCount()
    {
        return _throwCount;
    }
}