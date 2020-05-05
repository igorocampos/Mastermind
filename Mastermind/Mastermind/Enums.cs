using System;
using System.Drawing;

namespace Mastermind
{
    public enum eColor
    {
        White,
        Green,
        Blue,
        Red,
        Yellow,
        Purple,
        Pink
    }

    public static class Enums
    {
        public static Color ColorFromEnum(eColor color)
        {
            switch (color)
            {
                case eColor.White:  return Color.White;
                case eColor.Green:  return Color.Green;
                case eColor.Blue:   return Color.Blue;
                case eColor.Red:    return Color.Red;
                case eColor.Yellow: return Color.Yellow;
                case eColor.Purple: return Color.Purple;
                case eColor.Pink:   return Color.Pink;
                default: throw new ArgumentException("Invalid color code.", nameof(color));
            }
        }
    }
}
