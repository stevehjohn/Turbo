namespace Turbo.Framework;

public class Host
{
    private int _width;

    private int _height;

    private char[,] _buffer;
    
    public Host(int width, int height)
    {
        _width = width;
        
        _height = height;
        
        Reset();
    }

    private void Reset()
    {
        _buffer = new char[_width, _height];
        
        Clear();
    }

    private void Clear()
    {
        for (var x = 0; x < _width; x++)
        {
            for (var y = 0; y < _width; y++)
            {
                _buffer[x, y] = '░';
            }
        }
    }
}