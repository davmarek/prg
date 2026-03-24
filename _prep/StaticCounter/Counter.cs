class Counter
{
    private static int _count = 0;

    private string name = "";

    public static int GetCount()
    {
        return _count;
    }

    public static void Add()
    {
        _count++;
    }
}
