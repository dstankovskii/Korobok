using UnityEngine;
// ...

// On the path to creating an isometric view application, you may encounter many difficult tasks, 
// the solution to which is hard to find online. Here is an example of implementing rhombic isometry in C#:

// For convenience, a structure containing two integer coordinates is created
public struct PositionXY
{
    public int X;
    public int Y;
    public PositionXY(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }
}

// A structure containing two floating-point coordinates is also created
public struct floatXY
{
    public float X;
    public float Y;

    public floatXY(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }
}

public class Position
{
    private static PositionXY valueInt;
    private static floatXY valueFloat;
    // Offset of real coordinates when moving an object by one tile
    public static float dx = 1.132f, dy = 0.42f;

    // Determine field coordinates from screen object coordinates
    public static floatXY XYfloat(float Cx0, float Cy0, int X, int Y)
    {
        valueFloat.X = Cx0 + dx * (X + Y);
        valueFloat.Y = Cy0 + dy * (X - Y);
        return valueFloat;
    }

    // Determine screen coordinates from field object coordinates
    public static PositionXY intXY(floatXY Pos0, float fX, float fY)
    {
        int a = 0, b = 0;
        a = Mathf.RoundToInt((fX - Pos0.X) / dx);
        b = Mathf.RoundToInt((fY - Pos0.Y) / dy);
        valueInt.X = ((a + b) / 2);
        valueInt.Y = ((a - b) / 2);
        return valueInt;
    }
}
