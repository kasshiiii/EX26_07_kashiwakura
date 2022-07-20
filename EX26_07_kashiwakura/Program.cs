using System;

public class Box_Class
{
    static void Main()
    {
        Box box = new Box(InputFloat("幅を入力してください"), InputFloat("高さを入力してください"), InputFloat("奥行きを入力してください"));
        Console.WriteLine("表面積 = "+box.GetSurface());
        Console.WriteLine("体積 = "+box.GetVolume());
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
    float width,height,depth;
    public Box(float width,float height,float depth)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }
    public float GetSurface()
    {
        return (width*height+width*depth+height*depth)*2;
    }
    public float GetVolume()
    {
        return width*height*depth;
    }
}