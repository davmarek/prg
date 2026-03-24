class Wall
{
    string material;
    float width;
    float height;

    public Wall(string material, float width, float height)
    {
        this.material = material;
        this.width = width;
        this.height = height;
    }

    public float GetSurface()
    {
        return width * height;
    }

    public void PrintInfo()
    {
        Console.WriteLine(
                $"Wall: mat={material} w={width} h={height} "
                + $"surface={GetSurface()}");
    }
}
