class Book
{
    public string Name;
    public string Author;
    public int PageCount;
    public int ReleaseYear;

    public Book(string name, string author, int pageCount, int releaseYear)
    {
        Name = name;
        Author = author;
        PageCount = pageCount;
        ReleaseYear = releaseYear;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} - {Author} ({ReleaseYear}) [{PageCount}]");
    }

}
