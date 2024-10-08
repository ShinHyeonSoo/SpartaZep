using System;

public class Utils
{
    public enum CharacterType
    {
        Type_Penguin = 0,
        Type_Human,
    }

    public static string GetCurrentTime()
    {
        return DateTime.Now.ToString(("HH:mm:ss"));
    }
}
