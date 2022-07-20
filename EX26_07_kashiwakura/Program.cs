using System;
using InputUtilitys;

public class Bos_Class
{
    static void Main()
    {
        Box box = new Box(InputUtility.InputFloat(), InputUtility.InputFloat(), InputUtility.InputFloat());
        Console.WriteLine(box.GetSurface());
        Console.WriteLine(box.GetVolume());

    }
}
class Box
{
    float width;
    float height;
    float depth;
    public Box(float width,float height,float depth)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }
    public float GetSurface()
    {
        return width*height*6;
    }
    public float GetVolume()
    {
        return depth*width*depth;
    }
}