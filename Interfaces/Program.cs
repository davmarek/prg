var p = new VideoPlayer();
LogAndWriteInfo(p);

void LogAndWriteInfo(ILoggable p)
{
    Console.WriteLine("Some info");
    p.LogInfo();
}


interface IPlayable
{
    void Play()
    {
        Console.WriteLine("Some default play");
    }
    void Pause();
    void Stop()
    {

        Console.WriteLine("Not implemented yet");
    }


}

interface ILoggable
{
    void LogInfo();
}

class MusicPlayer : IPlayable, ILoggable
{
    public void LogInfo()
    {
    }

    public void Pause()
    {
    }

    public void Play()
    {
    }
}

class VideoPlayer : IPlayable
{
    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }
}







