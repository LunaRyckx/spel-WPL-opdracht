using System;
using System.Timers;

public class CookieClickerGame
{
    private int _cookies;
    private Timer _timer;

    public CookieClickerGame()
    {
        _cookies = 0;
        _timer = new Timer(1000);
        _timer.Elapsed += AddCookiePerSecond;
        _timer.AutoReset = true;
        _timer.Enabled = false;
    }

    public void StartGame()
    {
        _timer.Start();
    }

    public void ClickCookie()
    {
        _cookies++;
        Console.WriteLine($"Cookies: {_cookies}");
    }

    private void AddCookiePerSecond(Object source, ElapsedEventArgs e)
    {
        _cookies++;
        Console.WriteLine($"Cookies: {_cookies}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var game = new CookieClickerGame();
        game.StartGame();

        while (true)
        {
            Console.ReadKey();
            game.ClickCookie();
        }
    }
}
