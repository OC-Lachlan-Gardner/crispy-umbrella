class Timer
{
    public bool IsRunning = false;

    public int Seconds = 0;

    public void Start()
    {
        IsRunning = true;
    }

    public void Tick()
    {
        if (IsRunning)
        {
            Seconds++;
        }
    }

    public void Reset()
    {
        IsRunning = false;

        Seconds = 0;
    }

    public static void Update()
    {
        Console.WriteLine($"Timer runner: {IsRunning}");
        Console.WriteLine($"{Seconds} seconds have passed");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Timer newTimer = new Timer();

        newTimer.Start();
        newTimer.Update();

        newTimer.Tick();
        newTimer.Update();

        newTimer.Reset();
        newTimer.Update();
    }
}