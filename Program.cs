using SplashKitSDK;
using Task2._3C;

namespace Task2._3C;

public class Program
{
    public static void Main()
    {
        var gameWindow = new Window("Game", 1000, 1000);
        var player = new Player(gameWindow);
        player.Draw();
        gameWindow.Refresh();
        SplashKit.Delay(1000);
    }
}