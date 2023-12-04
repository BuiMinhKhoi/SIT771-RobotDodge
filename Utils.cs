namespace Task2._3C;

public static class Utils
{
    private const string DEFAULT_PLAYER_NAME_PREFIX = "player_";

    public static string generatePlayerName()
    {
        var random = new Random();
        var randomNumber = random.Next(100, 1000);
        var playerName = DEFAULT_PLAYER_NAME_PREFIX + randomNumber;
        return playerName;
    }
}