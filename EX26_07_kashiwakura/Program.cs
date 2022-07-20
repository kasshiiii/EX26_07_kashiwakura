using System;

public class Bos_Class
{
    static void Main()
    {
        Box box = new Box(InputFloat("幅を入力してください"), InputFloat("高さを入力してください"), InputFloat("奥行きを入力してください"));
        Console.WriteLine(box.GetSurface());
        Console.WriteLine(box.GetVolume());
    }

    static float InputFloat(string outputString)
    {
        float input;
        while (true)
        {
            Console.WriteLine(outputString);
            if(float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
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
        return width*height*depth;
    }
}