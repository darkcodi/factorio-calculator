namespace FactorioCalculator.Services;

public static class ColorGenerator
{
    public static string GetBackgroundColorForText(string str)
    {
        var hash = str.GetHashCode();
        var r = (hash & 0xFF0000) >> 16;
        var g = (hash & 0x00FF00) >> 8;
        var b = (hash & 0x0000FF);
        var color = String.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
        return color;
    }

    public static string GetForegroundColorForColor(string color)
    {
        var r = Convert.ToInt32(color.Substring(1, 2), 16);
        var g = Convert.ToInt32(color.Substring(3, 2), 16);
        var b = Convert.ToInt32(color.Substring(5, 2), 16);
        var luminance = (0.299 * r + 0.587 * g + 0.114 * b) / 255;
        return luminance > 0.5 ? "#000000" : "#FFFFFF";
    }
}