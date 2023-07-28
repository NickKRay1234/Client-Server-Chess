namespace Chess;

public enum Color
{
    none,
    white,
    black
}

internal static class ColorMethods
{
    public static Color FlipColor(this Color color)
    {
        return color switch
        {
            Color.black => Color.white,
            Color.white => Color.black,
            _ => Color.none
        };
    }
}