﻿// TODO:
// - Apply gradient method AddGradient(Color4 c1, Color4 c2, bool changeText = false, bool change Background = true);

namespace Game.Utility
{
    using System.Collections.Generic;
    using OpenTK.Graphics;
    using System.Collections;

    public class ColoredString : IEnumerable<ColoredChar>
    {
        private List<ColoredChar> _colChars;

        public ColoredString(string line, Color4 textColor, Color4 backgroundColor)
        {
            // TODO: Check if creating a list (or array) and use at the and List.AddRange at the end is faster.
            foreach(char ch in line) {
                _colChars.Add(new ColoredChar(ch, textColor, backgroundColor));
            }
        }

        public void Insert(int index, ColoredString colString)
        {
            _colChars.InsertRange(index, colString._colChars);
        }

        public static ColoredString operator +(ColoredString a, ColoredString b)
        {
            a._colChars.AddRange(b._colChars);
            return a;
        }

        public IEnumerator<ColoredChar> GetEnumerator() { return _colChars.GetEnumerator(); }
        
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }

    /// <summary>
    /// A colored string contains one or more colored char. Its the base of the colored string.
    /// </summary>
    public struct ColoredChar
    {
        public char Value;

        public Color4 TextColor;

        public Color4 BackgroundColor;

        public ColoredChar(char value, Color4 textColor, Color4 backgroundColor)
        {
            Value = value;
            TextColor = textColor;
            BackgroundColor = backgroundColor;
        }
    }
}
