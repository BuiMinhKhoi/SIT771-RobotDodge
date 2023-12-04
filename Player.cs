using SplashKitSDK;

namespace Task2._3C;

public class Player
{
    private const string DEFAULT_PLAYER_IMG = "Resources/images/Player.png";
    private readonly Bitmap playerBitmap;

    private double X { get; set; }
    private double Y { get; set; }

    private int Height => playerBitmap.Height;

    private int Width => playerBitmap.Width;


    public Player(Window gameWindow)
    {
        playerBitmap = new Bitmap(Utils.generatePlayerName(), DEFAULT_PLAYER_IMG);
        X = (gameWindow.Width - Width) / 2;
        Y = (gameWindow.Height - Height) / 2;
    }

    public void Draw()
    {
        playerBitmap.Draw(X, Y);
    }
}