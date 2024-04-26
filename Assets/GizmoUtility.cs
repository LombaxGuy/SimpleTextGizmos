using System;
using System.Collections.Generic;
using UnityEngine;

namespace Niila.Utility
{
    public static class GizmoUtility
    {
        private enum DrawType { ContinousLine, LinePieces }

        private struct PointArray
        {
            public DrawType DrawType;
            public float[] Points;

            public bool IsEmpty()
            {
                return Points == null || Points.Length == 0;
            }
        }

        #region Point arrays
        #region Numbers
        private static readonly PointArray POINTS_NUM0 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 5,
                2.66f, 5.66f,
                2, 6,
                1, 6,
                0.33f, 5.66f,
                0, 5,
                0, 1,
                0.33f, 0.33f,
                2.66f, 5.66f
            }
        };
        private static readonly PointArray POINTS_NUM1 = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 5,
                1.5f, 6,
                1.5f, 6,
                1.5f, 0,
                0, 0,
                3, 0
            }
        };
        private static readonly PointArray POINTS_NUM2 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0,5,
                0.33f, 5.66f,
                1, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5,
                3, 4,
                2.66f, 3.33f,
                0, 0,
                3, 0
            }
        };
        private static readonly PointArray POINTS_NUM3 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 5,
                0.33f, 5.66f,
                1, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5,
                3, 4,
                2.66f, 3.33f,
                2, 3,
                2.66f, 2.66f,
                3, 2,
                3, 1,
                2.66f, 0.33f,
                2, 0,
                1, 0,
                0.33f, 0.33f,
                0, 1
            }
        };
        private static readonly PointArray POINTS_NUM4 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                2.5f, 0,
                2.5f, 2,
                0, 2,
                2.5f, 6,
                2.5f, 2,
                3, 2
            }
        };
        private static readonly PointArray POINTS_NUM5 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 6,
                0, 6,
                0, 3f,
                1, 3.5f,
                2, 3.5f,
                2.66f, 3.16f,
                3, 2.5f,
                3, 1,
                2.66f, 0.33f,
                2, 0,
                1, 0,
                0.33f, 0.33f,
                0, 1
            }
        };
        private static readonly PointArray POINTS_NUM6 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 5,
                2.66f, 5.66f,
                2, 6,
                1, 6,
                0.33f, 5.66f,
                0, 5,
                0, 1,
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 2.5f,
                2.66f, 3.16f,
                2, 3.5f,
                1, 3.5f,
                0.33f, 3.16f,
                0, 2.5f
            }
        };
        private static readonly PointArray POINTS_NUM7 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 6,
                3, 6,
                1, 0
            }
        };
        private static readonly PointArray POINTS_NUM8 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1, 3,
                0.33f, 3.33f,
                0, 4,
                0, 5,
                0.33f, 5.66f,
                1, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5,
                3, 4,
                2.66f, 3.33f,
                2, 3,
                2.66f, 2.66f,
                3, 2,
                3, 1,
                2.66f, 0.33f,
                2, 0,
                1, 0,
                0.33f, 0.33f,
                0, 1,
                0, 2,
                0.33f, 2.66f,
                1, 3,
                2, 3
            }
        };
        private static readonly PointArray POINTS_NUM9 = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 1,
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 5,
                2.66f, 5.66f,
                2, 6,
                1, 6,
                0.33f, 5.66f,
                0, 5,
                0, 3.5f,
                0.33f, 2.83f,
                1, 2.5f,
                2, 2.5f,
                2.66f, 2.83f,
                3, 3.5f
            }
        };
        private static readonly PointArray POINTS_HALF = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
    {
                1, 5.5f,
                1.5f, 6,
                1.5f, 6,
                1.5f, 3.5f,
                1, 3.5f,
                2, 3.5f,

                0, 3,
                3, 3,

                2.5f, 0,
                0.5f, 0,
                0.5f, 0,
                2.33f, 1,
                2.33f, 1,
                2.5f, 1.5f,
                2.5f, 1.5f,
                2.33f, 2.16f,
                2.33f, 2.16f,
                1.66f, 2.5f,
                1.66f, 2.5f,
                1.33f, 2.5f,
                1.33f, 2.5f,
                0.66f, 2.16f,
                0.66f, 2.16f,
                0.5f, 1.5f
    }
        };
        #endregion

        #region Symbols
        private static readonly PointArray POINTS_UNKNOWN = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                0, 6,
                3, 6,
                3, 0,
                0, 0,
                3, 6
            }
        };
        private static readonly PointArray POINTS_COMMA = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                2, 1,
                1, -1
            }
        };
        private static readonly PointArray POINTS_OPEN_PARENTHESIS = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1.66f, 0,
                1.33f, 0.33f,
                1, 1,
                0.66f, 2,
                0.5f, 3,
                0.66f, 4,
                1, 5,
                1.33f, 5.66f,
                1.66f, 6
            }
        };
        private static readonly PointArray POINTS_CLOSE_PARENTHESIS = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1.33f, 0,
                1.66f, 0.33f,
                2, 1,
                2.33f, 2,
                2.5f, 3,
                2.33f, 4,
                2, 5,
                1.66f, 5.66f,
                1.33f, 6
            }
        };
        private static readonly PointArray POINTS_PLUS = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0.5f, 3,
                2.5f, 3,
                1.5f, 2,
                1.5f, 4
            }
        };
        private static readonly PointArray POINTS_MINUS = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0.5f, 3,
                2.5f, 3
            }
        };
        private static readonly PointArray POINTS_SLASH = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                3, 6
            }
        };
        private static readonly PointArray POINTS_STAR = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1.5f, 3,
                1.5f, 4,
                1.5f, 3,
                2.33f, 3.33f,
                1.5f, 3,
                2, 2.33f,
                1.5f, 3,
                1, 2.33f,
                1.5f, 3,
                0.66f, 3.33f
            }
        };
        private static readonly PointArray POINTS_EQUAL = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0.5f, 2.5f,
                2.5f, 2.5f,
                0.5f, 3.5f,
                2.5f, 3.5f
            }
        };
        private static readonly PointArray POINTS_PERCENT = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                3, 6,
                2, 0.33f,
                2, 0.66f,
                2, 0.66f,
                2.33f, 1,
                2.33f, 1,
                2.66f, 1,
                2.66f, 1,
                3, 0.66f,
                3, 0.66f,
                3, 0.33f,
                3, 0.33f,
                2.66f, 0,
                2.66f, 0,
                2.33f, 0,
                2.33f, 0,
                2, 0.33f,
                0, 5.33f,
                0, 5.66f,
                0, 5.66f,
                0.33f, 6,
                0.33f, 6,
                0.66f, 6,
                0.66f, 6,
                1, 5.66f,
                1, 5.66f,
                1, 5.33f,
                1, 5.33f,
                0.66f, 5,
                0.66f, 5,
                0.33f, 5,
                0.33f, 5,
                0, 5.33f
            }
        };
        private static readonly PointArray POINTS_DOT = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1.25f, 0.16f,
                1.41f, 0,
                1.41f, 0,
                1.59f, 0,
                1.59f, 0,
                1.75f, 0.16f,
                1.75f, 0.16f,
                1.75f, 0.34f,
                1.75f, 0.34f,
                1.59f, 0.5f,
                1.59f, 0.5f,
                1.41f, 0.5f,
                1.41f, 0.5f,
                1.25f, 0.34f,
                1.25f, 0.34f,
                1.25f, 0.16f
            }
        };
        private static readonly PointArray POINTS_COLON = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1.25f, 0.16f,
                1.41f, 0,
                1.41f, 0,
                1.59f, 0,
                1.59f, 0,
                1.75f, 0.16f,
                1.75f, 0.16f,
                1.75f, 0.34f,
                1.75f, 0.34f,
                1.59f, 0.5f,
                1.59f, 0.5f,
                1.41f, 0.5f,
                1.41f, 0.5f,
                1.25f, 0.34f,
                1.25f, 0.34f,
                1.25f, 0.16f,

                1.25f, 3.66f,
                1.41f, 3.5f,
                1.41f, 3.5f,
                1.59f, 3.5f,
                1.59f, 3.5f,
                1.75f, 3.66f,
                1.75f, 3.66f,
                1.75f, 3.84f,
                1.75f, 3.84f,
                1.59f, 4,
                1.59f, 4,
                1.41f, 4,
                1.41f, 4,
                1.25f, 3.84f,
                1.25f, 3.84f,
                1.25f, 3.66f
            }
        };
        private static readonly PointArray POINTS_SEMICOLON = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                2, 1,
                1, -1,

                1.25f, 3.66f,
                1.41f, 3.5f,
                1.41f, 3.5f,
                1.59f, 3.5f,
                1.59f, 3.5f,
                1.75f, 3.66f,
                1.75f, 3.66f,
                1.75f, 3.84f,
                1.75f, 3.84f,
                1.59f, 4,
                1.59f, 4,
                1.41f, 4,
                1.41f, 4,
                1.25f, 3.84f,
                1.25f, 3.84f,
                1.25f, 3.66f
            }
        };
        private static readonly PointArray POINTS_EXCLAMATION = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1.5f, 6,
                1.5f, 2,
                1.5f, 1,
                1.5f, 0
            }
        };
        private static readonly PointArray POINTS_QUESTION = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1.5f, 1,
                1.5f, 0,
                1.5f, 2,
                1.5f, 3,
                1.5f, 3,
                2, 3,
                2, 3,
                2.66f, 3.33f,
                2.66f, 3.33f,
                3, 4,
                3, 4,
                3, 5,
                3, 5,
                2.66f, 5.66f,
                2.66f, 5.66f,
                2, 6,
                2, 6,
                1, 6,
                1, 6,
                0.33f, 5.66f,
                0.33f, 5.66f,
                0, 5
            }
        };
        private static readonly PointArray POINTS_VERTICAL_LINE = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1.5f, 0,
                1.5f, 6
            }
        };
        private static readonly PointArray POINTS_LESS = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                2.5f, 2,
                0.5f, 3,
                2.5f, 4
            }
        };
        private static readonly PointArray POINTS_GREATER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0.5f, 2,
                2.5f, 3,
                0.5f, 4
            }
        };
        private static readonly PointArray POINTS_UNDERSCORE = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                3, 0
            }
        };
        private static readonly PointArray POINTS_SINGLE_QUOTE = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1.5f, 6,
                1.5f, 5
            }
        };
        private static readonly PointArray POINTS_DOUBLE_QUOTE = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1, 6,
                1, 5,
                2, 6,
                2, 5
            }
        };
        private static readonly PointArray POINTS_APOSTROPHE = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1, 6,
                2, 5
            }
        };
        private static readonly PointArray POINTS_APOSTROPHE_BACK = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                2, 6,
                1, 5
            }
        };
        private static readonly PointArray POINTS_BACKSLASH = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 6,
                3, 0
            }
        };
        private static readonly PointArray POINTS_OPEN_SQUAREBRACKET = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                2, 0,
                1, 0,
                1, 6,
                2, 6
            }
        };
        private static readonly PointArray POINTS_CLOSE_SQUAREBRACKET = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1, 6,
                2, 6,
                2, 0,
                1, 0
            }
        };
        private static readonly PointArray POINTS_OPEN_CURLYBRACKET = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                2, 6,
                1.33f, 5.66f,
                1, 5,
                1, 3.5f,
                0.5f, 3,
                1, 2.5f,
                1, 1,
                1.33f, 0.33f,
                2, 0
            }
        };
        private static readonly PointArray POINTS_CLOSE_CURLYBRACKET = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1, 6,
                1.66f, 5.66f,
                2, 5,
                2, 3.5f,
                2.5f, 3,
                2, 2.5f,
                2, 1,
                1.66f, 0.33f,
                1, 0
            }
        };
        private static readonly PointArray POINTS_HASHTAG = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0.5f, 0,
                1, 6,
                2, 0,
                2.5f, 6,
                0, 4,
                3, 4,
                0, 2,
                3, 2
            }
        };
        private static readonly PointArray POINTS_AT = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                2, 0,
                1, 0,
                0.33f, 0.33f,
                0, 1,
                0, 5,
                0.33f, 5.66f,
                1, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5,
                3, 2,
                2.85f, 1.15f,
                2.5f, 1,
                2.15f, 1.15f,
                2, 1.5f,
                2, 4.5f,
                1.85f, 4.85f,
                1.5f, 5,
                1.15f, 4.85f,
                1, 4.5f,
                1, 1.5f,
                1.15f, 1.15f,
                1.5f, 1,
                1.85f, 1.15f,
                2, 1.5f
            }
        };
        private static readonly PointArray POINTS_DOLLAR = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1.5f, 6.5f,
                1.5f, -0.5f,
                3, 5,
                2.66f, 5.66f,
                2.66f, 5.66f,
                2, 6,
                2, 6,
                1, 6,
                1, 6,
                0.33f, 5.66f,
                0.33f, 5.66f,
                0, 5,
                0, 5,
                0, 4,
                0, 4,
                0.33f, 3.33f,
                0.33f, 3.33f,
                1, 3,
                1, 3,
                2, 3,
                2, 3,
                2.66f, 2.66f,
                2.66f, 2.66f,
                3, 2,
                3, 2,
                3, 1,
                3, 1,
                2.66f, 0.33f,
                2.66f, 0.33f,
                2, 0,
                2, 0,
                1, 0,
                1, 0,
                0.33f, 0.33f,
                0.33f, 0.33f,
                0, 1
            }
        };
        private static readonly PointArray POINTS_AND = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 3,
                1.66f, 0.33f,
                1, 0,
                0.33f, 0.33f,
                0, 1,
                0, 2,
                0.33f, 2.66f,
                1, 3,
                1.66f, 3.33f,
                2, 4,
                1.66f, 4.66f,
                1, 5,
                0.33f, 4.66f,
                0, 4,
                0.33f, 3.33f,
                1, 3,
                1.66f, 2.66f,
                2, 2,
                3, 0

            }
        };
        private static readonly PointArray POINTS_CURRENCY = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0.5f, 3,
                0.66f, 2.33f,
                0.66f, 2.33f,
                1.5f, 2,
                1.5f, 2,
                2.33f, 2.33f,
                2.33f, 2.33f,
                2.5f, 3,
                2.5f, 3,
                2.33f, 3.66f,
                2.33f, 3.66f,
                1.5f, 4,
                1.5f, 4,
                0.66f, 3.66f,
                0.66f, 3.66f,
                0.5f, 3,

                0.66f, 2.33f,
                0, 1.5f,

                2.33f, 2.33f,
                3, 1.5f,

                2.33f, 3.66f,
                3, 4.5f,

                0.66f, 3.66f,
                0, 4.5f
            }
        };
        private static readonly PointArray POINTS_POWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1, 5,
                1.5f, 6,
                2, 5
            }
        };
        private static readonly PointArray POINTS_TILDE = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0.5f, 3,
                0.75f, 3.22f,
                1, 3.33f,
                1.25f, 3.22f,
                1.5f, 3,
                1.75f, 2.77f,
                2, 2.66f,
                2.25f, 2.77f,
                2.5f, 3
            }
        };

        #endregion

        #region Letters
        private static readonly PointArray POINTS_A = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                1.5f, 6,
                1.5f, 6,
                3, 0,
                0.5f, 2,
                2.5f, 2
            }
        };
        private static readonly PointArray POINTS_A_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                3, 1,
                2.66f, 0.33f,
                2.66f, 0.33f,
                2, 0,
                2, 0,
                1, 0,
                1, 0,
                0.33f, 0.33f,
                0.33f, 0.33f,
                0, 1,
                0, 1,
                0, 2,
                0, 2,
                0.33f, 2.66f,
                0.33f, 2.66f,
                1, 3,
                1, 3,
                2, 3,
                2, 3,
                2.66f, 2.66f,
                2.66f, 2.66f,
                3, 2,
                3, 2,
                3, 0,
                3, 2,
                3, 3,
                3, 3,
                2.66f, 3.66f,
                2.66f, 3.66f,
                2, 4,
                2, 4,
                0.66f, 4,
                0.66f, 4,
                0, 3.66f
            }
        };
        private static readonly PointArray POINTS_B = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 3,
                0, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 2,
                2.66f, 2.66f,
                2, 3,
                0, 3,
                0, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5,
                3, 4,
                2.66f, 3.33f,
                2, 3
            }
        };
        private static readonly PointArray POINTS_B_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 6,
                0, 0,
                1.5f, 0,
                2.5f, 0.5f,
                3, 1.5f,
                3, 2.5f,
                2.5f, 3.5f,
                1.5f, 4,
                0, 4
            }
        };
        private static readonly PointArray POINTS_C = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 5.85f,
                2.5f, 6,
                1.5f, 6,
                0.5f, 5.33f,
                0, 4,
                0, 2,
                0.5f, 0.66f,
                1.5f, 0,
                2.5f, 0,
                3, 0.15f
            }
        };
        private static readonly PointArray POINTS_C_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 3.85f,
                2.5f, 4,
                1.5f, 4,
                0.5f, 3.66f,
                0, 2.5f,
                0, 1.5f,
                0.5f, 0.33f,
                1.5f, 0,
                2.5f, 0,
                3, 0.15f
            }
        };
        private static readonly PointArray POINTS_D = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                1, 0,
                2.33f, 0.66f,
                3, 2,
                3, 4,
                2.33f, 5.33f,
                1, 6,
                0, 6,
                0, 0
            }
        };
        private static readonly PointArray POINTS_D_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                3, 6,
                3, 0,

                3, 3,
                2.66f, 3.66f,
                2.66f, 3.66f,
                2, 4,
                2, 4,
                1, 4,
                1, 4,
                0.33f, 3.66f,
                0.33f, 3.66f,
                0, 3,
                0, 3,
                0, 1,
                0, 1,
                0.33f, 0.33f,
                0.33f, 0.33f,
                1, 0,
                1, 0,
                2, 0,
                2, 0,
                2.66f, 0.33f,
                2.66f, 0.33f,
                3, 1
            }
        };
        private static readonly PointArray POINTS_E = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                3, 6,
                0, 6,
                0, 6,
                0, 0,
                0, 0,
                3, 0,
                0, 3,
                2, 3
            }
        };
        private static readonly PointArray POINTS_E_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 1,
                2.66f, 0.33f,
                2, 0,
                1, 0,
                0.33f, 0.33f,
                0, 1,
                0, 3,
                0.33f, 3.66f,
                1, 4,
                2, 4,
                2.66f, 3.66f,
                3, 3,
                3, 2,
                0, 2
            }
        };
        private static readonly PointArray POINTS_F = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                3, 6,
                0, 6,
                0, 6,
                0, 0,
                0, 3,
                2, 3
            }
        };
        private static readonly PointArray POINTS_F_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1, 0,
                1, 5,
                1, 5,
                1.33f, 5.66f,
                1.33f, 5.66f,
                2, 6,
                2, 6,
                3, 6,

                0, 3,
                2, 3
            }
        };
        private static readonly PointArray POINTS_G = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1.5f, 3,
                3, 3,
                3, 1,
                2.66f, 0.33f,
                2, 0,
                1, 0,
                0.33f, 0.33f,
                0, 1,
                0, 5,
                0.33f, 5.66f,
                1, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5
            }
        };
        private static readonly PointArray POINTS_G_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                3, 4,
                3, 3,

                3, 1,
                2.66f, 0.33f,
                2.66f, 0.33f,
                2, 0,
                2, 0,
                1, 0,
                1, 0,
                0.33f, 0.33f,
                0.33f, 0.33f,
                0, 1,
                0, 1,
                0, 3,
                0, 3,
                0.33f, 3.66f,
                0.33f, 3.66f,
                1, 4,
                1, 4,
                2, 4,
                2, 4,
                2.66f, 3.66f,
                2.66f, 3.66f,
                3, 3,
                3, 3,
                3, -1,
                3, -1,
                2.66f, -1.66f,
                2.66f, -1.66f,
                2, -2,
                2, -2,
                0.66f, -2,
                0.66f, -2,
                0, -1.66f
            }
        };
        private static readonly PointArray POINTS_H = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                0, 6,
                0, 3,
                3, 3,
                3, 0,
                3, 6
            }
        };
        private static readonly PointArray POINTS_H_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                0, 6,
                0, 3,
                0.33f, 3.66f,
                0.33f, 3.66f,
                1, 4,
                1, 4,
                2, 4,
                2, 4,
                2.66f, 3.66f,
                2.66f, 3.66f,
                3, 3,
                3, 3,
                3, 0
            }
        };
        private static readonly PointArray POINTS_I = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                3, 0,
                0, 6,
                3, 6,
                1.5f, 0,
                1.5f, 6
            }
        };
        private static readonly PointArray POINTS_I_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                1, 0,
                2, 0,
                1.5f, 0,
                1.5f, 4,
                1.5f, 5,
                1.5f, 6,
                1, 4,
                1.5f, 4
            }
        };
        private static readonly PointArray POINTS_J = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 1,
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 6,
                0, 6
            }
        };
        private static readonly PointArray POINTS_J_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, -2,
                0.5f, -2,
                0.5f, -2,
                1.16f, -1.66f,
                1.16f, -1.66f,
                1.5f, -1,
                1.5f, -1,
                1.5f, 4,
                1.5f, 4,
                1, 4,

                1.5f, 5,
                1.5f, 6
            }
        };
        private static readonly PointArray POINTS_K = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                0, 6,
                0, 3,
                3, 6,
                0.5f, 3.5f,
                3, 0
            }
        };
        private static readonly PointArray POINTS_K_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                0, 6,
                0, 2,
                3, 4,
                0.5f, 2.33f,
                3, 0
            }
        };
        private static readonly PointArray POINTS_L = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 6,
                0, 0,
                3, 0
            }
        };
        private static readonly PointArray POINTS_L_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                1, 6,
                1.5f, 6,
                1.5f, 0,
                2, 0
            }
        };
        private static readonly PointArray POINTS_M = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                0, 6,
                1.5f, 3,
                3, 6,
                3, 0
            }
        };
        private static readonly PointArray POINTS_M_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                0, 4,
                0, 3,
                0.25f, 3.66f,
                0.25f, 3.66f,
                0.75f, 4,
                0.75f, 4,
                1.25f, 3.66f,
                1.25f, 3.66f,
                1.5f, 3,
                1.5f, 3,
                1.5f, 0,
                1.5f, 3,
                1.75f, 3.66f,
                1.75f, 3.66f,
                2.25f, 4, 
                2.25f, 4,
                2.75f, 3.66f,
                2.75f, 3.66f,
                3, 3,
                3, 3,
                3, 0
            }
        };
        private static readonly PointArray POINTS_N = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                0, 6,
                3, 0,
                3, 6
            }
        };
        private static readonly PointArray POINTS_N_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                0, 4,
                0, 3,
                0.33f, 3.66f,
                0.33f, 3.66f,
                1, 4,
                1, 4,
                2, 4,
                2, 4,
                2.66f, 3.66f,
                2.66f, 3.66f,
                3, 3,
                3, 3,
                3, 0
            }
        };
        private static readonly PointArray POINTS_O = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 1,
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 5,
                2.66f, 5.66f,
                2, 6,
                1, 6,
                0.33f, 5.66f,
                0, 5,
                0, 1
            }
        };
        private static readonly PointArray POINTS_O_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 1,
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 3,
                2.66f, 3.66f,
                2, 4,
                1, 4,
                0.33f, 3.66f,
                0, 3,
                0, 1
            }
        };
        private static readonly PointArray POINTS_P = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                0, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5,
                3, 4,
                2.66f, 3.33f,
                2, 3,
                0, 3
            }
        };
        private static readonly PointArray POINTS_P_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 4,
                0, -2,

                0, 3,
                0.33f, 3.66f,
                0.33f, 3.66f,
                1, 4,
                1, 4,
                2, 4,
                2, 4,
                2.66f, 3.66f,
                2.66f, 3.66f,
                3, 3,
                3, 3,
                3, 1,
                3, 1,
                2.66f, 0.33f,
                2.66f, 0.33f,
                2, 0,
                2, 0,
                1, 0,
                1, 0,
                0.33f, 0.33f,
                0.33f, 0.33f,
                0, 1
            }
        };
        private static readonly PointArray POINTS_Q = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                2, 1,
                3, 0,

                0, 1,
                0.33f, 0.33f,
                0.33f, 0.33f,
                1, 0,
                1, 0,
                2, 0,
                2, 0,
                2.66f, 0.33f,
                2.66f, 0.33f,
                3, 1,
                3, 1,
                3, 5,
                3, 5,
                2.66f, 5.66f,
                2.66f, 5.66f,
                2, 6,
                2, 6,
                1, 6,
                1, 6,
                0.33f, 5.66f,
                0.33f, 5.66f,
                0, 5,
                0, 5,
                0, 1
            }
        };
        private static readonly PointArray POINTS_Q_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                3, 4, 
                3, -2,

                3, 3,
                2.66f, 3.66f,
                2.66f, 3.66f,
                2, 4,
                2, 4,
                1, 4,
                1, 4,
                0.33f, 3.66f,
                0.33f, 3.66f,
                0, 3,
                0, 3,
                0, 1,
                0, 1,
                0.33f, 0.33f,
                0.33f, 0.33f,
                1, 0,
                1, 0,
                2, 0,
                2, 0,
                2.66f, 0.33f,
                2.66f, 0.33f,
                3, 1
            }
        };
        private static readonly PointArray POINTS_R = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0,
                0, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5,
                3, 4,
                2.66f, 3.33f,
                2, 3,
                0, 3,
                3, 0
            }
        };
        private static readonly PointArray POINTS_R_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                0, 4,
                0, 3,
                0.33f, 3.66f,
                0.33f, 3.66f,
                1, 4,
                1, 4,
                2, 4,
                2, 4,
                2.66f, 3.66f,
                2.66f, 3.66f,
                3, 3
            }
        };
        private static readonly PointArray POINTS_S = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 1,
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 2,
                2.66f, 2.66f,
                2, 3,
                1, 3,
                0.33f, 3.33f,
                0, 4,
                0, 5,
                0.33f, 5.66f,
                1, 6,
                2, 6,
                2.66f, 5.66f,
                3, 5
            }
        };
        private static readonly PointArray POINTS_S_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                2.66f, 1.66f,
                2, 2,
                1, 2,
                0.33f, 2.33f,
                0, 3,
                0.33f, 3.66f,
                1, 4,
                2, 4,
                3, 3.66f
            }
        };
        private static readonly PointArray POINTS_T = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 6,
                3, 6,
                1.5f, 0, 
                1.5f, 6
            }
        };
        private static readonly PointArray POINTS_T_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 4,
                2, 4,

                1, 6,
                1, 1,
                1, 1,
                1.33f, 0.33f,
                1.33f, 0.33f,
                2, 0,
                2, 0,
                2.66f, 0.33f,
                2.66f, 0.33f,
                3, 1
            }
        };
        private static readonly PointArray POINTS_U = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 6,
                0, 1,
                0.33f, 0.33f,
                1, 0,
                2, 0,
                2.66f, 0.33f,
                3, 1,
                3, 6
            }
        };
        private static readonly PointArray POINTS_U_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                3, 4,
                3, 0,

                0, 4,
                0, 1,
                0, 1,
                0.33f, 0.33f,
                0.33f, 0.33f,
                1, 0,
                1, 0,
                2, 0,
                2, 0,
                2.66f, 0.33f,
                2.66f, 0.33f,
                3, 1,
            }
        };
        private static readonly PointArray POINTS_V = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 6,
                1.5f, 0,
                3, 6
            }
        };
        private static readonly PointArray POINTS_V_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 4,
                1.5f, 0,
                3, 4
            }
        };
        private static readonly PointArray POINTS_W = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 6,
                0.75f, 0,
                1.5f, 4,
                2.25f, 0,
                3, 6
            }
        };
        private static readonly PointArray POINTS_W_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                0, 4,
                0.75f, 0,
                1.5f, 4,
                2.25f, 0,
                3, 4
            }
        };
        private static readonly PointArray POINTS_X = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                3, 6,
                3, 0,
                0, 6
            }
        };
        private static readonly PointArray POINTS_X_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 0,
                3, 4,
                3, 0,
                0, 4
            }
        };
        private static readonly PointArray POINTS_Y = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 6,
                1.5f, 3,
                1.5f, 3,
                3, 6,
                1.5f, 3,
                1.5f, 0
            }
        };
        private static readonly PointArray POINTS_Y_LOWER = new PointArray
        {
            DrawType = DrawType.LinePieces,
            Points = new float[]
            {
                0, 4,
                1.5f, 0,
                3, 4,
                1, -1.33f,
                1, -1.33f,
                0, -2
            }
        };
        private static readonly PointArray POINTS_Z = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 0,
                0, 0,
                3, 6,
                0, 6
            }
        };
        private static readonly PointArray POINTS_Z_LOWER = new PointArray
        {
            DrawType = DrawType.ContinousLine,
            Points = new float[]
            {
                3, 0,
                0, 0,
                3, 4,
                0, 4
            }
        };
        #endregion
        #endregion

        #region Private static and const fields
        // the size of the characters in the character definitions
        private const float CHARACTER_WIDTH = 3.0f;
        private const float CHARACTER_HEIGHT = 6.0f;
        private const float CHARACTER_SPACING = 0.5f;

        // dictionary containing all our symbols
        private static readonly Dictionary<char, PointArray> SYMBOLS = new Dictionary<char, PointArray>()
        {
            { ' ', default },
            { '0', POINTS_NUM0 },
            { '1', POINTS_NUM1 },
            { '2', POINTS_NUM2 },
            { '3', POINTS_NUM3 },
            { '4', POINTS_NUM4 },
            { '5', POINTS_NUM5 },
            { '6', POINTS_NUM6 },
            { '7', POINTS_NUM7 },
            { '8', POINTS_NUM8 },
            { '9', POINTS_NUM9 },
            { '½', POINTS_HALF },
            { '(', POINTS_OPEN_PARENTHESIS },
            { ')', POINTS_CLOSE_PARENTHESIS },
            { ',', POINTS_COMMA },
            { '+', POINTS_PLUS },
            { '-', POINTS_MINUS },
            { '/', POINTS_SLASH },
            { '*', POINTS_STAR },
            { '=', POINTS_EQUAL },
            { '%', POINTS_PERCENT },
            { '.', POINTS_DOT },
            { ':', POINTS_COLON },
            { ';', POINTS_SEMICOLON },
            { '!', POINTS_EXCLAMATION },
            { '?', POINTS_QUESTION },
            { '|', POINTS_VERTICAL_LINE },
            { '<', POINTS_LESS },
            { '>', POINTS_GREATER },
            { '_', POINTS_UNDERSCORE },
            { '\'', POINTS_SINGLE_QUOTE },
            { '"', POINTS_DOUBLE_QUOTE },
            { '`', POINTS_APOSTROPHE },
            { '´', POINTS_APOSTROPHE_BACK },
            { '\\', POINTS_BACKSLASH },
            { '[', POINTS_OPEN_SQUAREBRACKET },
            { ']', POINTS_CLOSE_SQUAREBRACKET },
            { '{', POINTS_OPEN_CURLYBRACKET },
            { '}', POINTS_CLOSE_CURLYBRACKET },
            { '#', POINTS_HASHTAG },
            { '@', POINTS_AT },
            { '$', POINTS_DOLLAR },
            { '&', POINTS_AND },
            { '¤', POINTS_CURRENCY },
            { '^', POINTS_POWER },
            { '~', POINTS_TILDE },
            { 'A', POINTS_A },
            { 'a', POINTS_A_LOWER },
            { 'B', POINTS_B },
            { 'b', POINTS_B_LOWER },
            { 'C', POINTS_C },
            { 'c', POINTS_C_LOWER },
            { 'D', POINTS_D },
            { 'd', POINTS_D_LOWER },
            { 'E', POINTS_E },
            { 'e', POINTS_E_LOWER },
            { 'F', POINTS_F },
            { 'f', POINTS_F_LOWER },
            { 'G', POINTS_G },
            { 'g', POINTS_G_LOWER },
            { 'H', POINTS_H },
            { 'h', POINTS_H_LOWER },
            { 'I', POINTS_I },
            { 'i', POINTS_I_LOWER },
            { 'J', POINTS_J },
            { 'j', POINTS_J_LOWER },
            { 'K', POINTS_K },
            { 'k', POINTS_K_LOWER },
            { 'L', POINTS_L },
            { 'l', POINTS_L_LOWER },
            { 'M', POINTS_M },
            { 'm', POINTS_M_LOWER },
            { 'N', POINTS_N },
            { 'n', POINTS_N_LOWER },
            { 'O', POINTS_O },
            { 'o', POINTS_O_LOWER },
            { 'P', POINTS_P },
            { 'p', POINTS_P_LOWER },
            { 'Q', POINTS_Q },
            { 'q', POINTS_Q_LOWER },
            { 'R', POINTS_R },
            { 'r', POINTS_R_LOWER },
            { 'S', POINTS_S },
            { 's', POINTS_S_LOWER },
            { 'T', POINTS_T },
            { 't', POINTS_T_LOWER },
            { 'U', POINTS_U },
            { 'u', POINTS_U_LOWER },
            { 'V', POINTS_V },
            { 'v', POINTS_V_LOWER },
            { 'W', POINTS_W },
            { 'w', POINTS_W_LOWER },
            { 'X', POINTS_X },
            { 'x', POINTS_X_LOWER },
            { 'Y', POINTS_Y },
            { 'y', POINTS_Y_LOWER },
            { 'Z', POINTS_Z },
            { 'z', POINTS_Z_LOWER }
        };

        // point buffer for when we modify points
        private static Vector3[] _pointsBuffer = new Vector3[50]; // we cannot draw symbols with more than this number of points
        private static int _bufferedPointCount = 0;
        #endregion

        #region Public static methods
        /// <summary>
        /// Draws a text string as a gizmo in world space.
        /// </summary>
        /// <param name="text">The string we want to draw.</param>
        /// <param name="position">The position we want to draw the string at.</param>
        /// <param name="scale">The scale of the letters. A scale of 1.0 is equivalent to a character height of 1 unit.</param>
        /// <param name="center">Should the text be centered on the position?</param>
        /// <param name="drawDistance">The distance to the scene view camera at which the gizmo is drawn. A value below 0 means that the gizmo is always drawn.</param>
        /// <param name="neverCull">Set this to true if you want the gizmo to draw even when off screen (from the scene views perspective).</param>
        public static void DrawString(string text, Vector3 position, float scale = 1.0f, bool center = true, float drawDistance = -1, bool neverCull = false)
        {
#if UNITY_EDITOR
            DrawString(text, position, Vector3.zero, scale, center, drawDistance, neverCull);
#endif
        }

        /// <summary>
        /// Draws a text string as a gizmo in world space.
        /// </summary>
        /// <param name="text">The string we want to draw.</param>
        /// <param name="position">The position we want to draw the string at.</param>
        /// <param name="eulerRotation">The euler rotation we want to draw the string with.</param>
        /// <param name="scale">The scale of the letters. A scale of 1.0 is equivalent to a character height of 1 unit.</param>
        /// <param name="center">Should the text be centered on the position?</param>
        /// <param name="drawDistance">The distance to the scene view camera at which the gizmo is drawn. A value below 0 means that the gizmo is always drawn.</param>
        /// <param name="neverCull">Set this to true if you want the gizmo to draw even when off screen (from the scene views perspective).</param>
        public static void DrawString(string text, Vector3 position, Vector3 eulerRotation, float scale = 1.0f, bool center = true, float drawDistance = -1, bool neverCull = false)
        {
#if UNITY_EDITOR
            var camera = UnityEditor.SceneView.currentDrawingSceneView.camera;
            var viewportPoint = camera.WorldToViewportPoint(position);

            // if the gizmo is off-screen and neverCull is not true, dont draw it
            if (!neverCull && (!IsInRange(viewportPoint.x, 0, 1) || !IsInRange(viewportPoint.y, 0, 1) || viewportPoint.z <= 0))
                return;

            // if the gizmo is beyond the draw distance, dont draw it
            if (drawDistance > 0 && Vector3.SqrMagnitude(camera.transform.position - position) > drawDistance * drawDistance)
                return;

            var totalWidth = (text.Length * (CHARACTER_WIDTH + CHARACTER_SPACING) - CHARACTER_SPACING) * scale / CHARACTER_HEIGHT;
            var totalHeight = CHARACTER_HEIGHT * scale / CHARACTER_HEIGHT;

            for (int i = 0; i < text.Length; i++)
            {
                DrawPoints(GetPointArray(text[i]), i, totalWidth, totalHeight, scale, position, eulerRotation, center);
            }
#endif
        }
        #endregion

        #region Private static methods
        /// <summary>
        /// Transforms and draws a set of points given as a float array.
        /// </summary>
        /// <param name="pointArray">The point array we want to draw.</param>
        /// <param name="characterIndex">The index of the character we are drawing. Used to offset the character.</param>
        /// <param name="totalWidth">The total width of the string we are drawing in world space. Used to offset the whole string if we want to center the text.</param>
        /// <param name="totalHeight">The total height of the string we are drawing in world space. Used to offset the whole string if we want to center the text.</param>
        /// <param name="scale">The scale of the characters. A scale of 1.0 is equivalent to character height of 1 unit.</param>
        /// <param name="position">The position of the whole string in world space.</param>
        /// <param name="eulerRotation">The rotation of the whole string in world space.</param>
        /// <param name="center">Should the text be centered on the position?</param>
        private static void DrawPoints(PointArray pointArray, int characterIndex, float totalWidth, float totalHeight, float scale, Vector3 position, Vector3 eulerRotation, bool center)
        {
            if (pointArray.IsEmpty())
                return;

            _bufferedPointCount = pointArray.Points.Length / 2;

            for (int i = 0; i < pointArray.Points.Length; i += 2)
            {
                _pointsBuffer[i / 2] = Vector3.zero;
                _pointsBuffer[i / 2].x = (CHARACTER_WIDTH * characterIndex + CHARACTER_SPACING * characterIndex + pointArray.Points[i]) * scale / CHARACTER_HEIGHT;
                _pointsBuffer[i / 2].y = pointArray.Points[i + 1] * scale / CHARACTER_HEIGHT;

                if (center)
                {
                    _pointsBuffer[i / 2].x -= totalWidth / 2f;
                    _pointsBuffer[i / 2].y -= totalHeight / 2f;
                }

                _pointsBuffer[i / 2] = Quaternion.Euler(eulerRotation) * _pointsBuffer[i / 2] + position;
            }

            if (pointArray.DrawType == DrawType.ContinousLine)
                Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(_pointsBuffer, 0, _bufferedPointCount), false);
            else
                Gizmos.DrawLineList(new ReadOnlySpan<Vector3>(_pointsBuffer, 0, _bufferedPointCount));
        }

        /// <summary>
        /// Helper method that returns the appropriate point array based on an input character.
        /// </summary>
        /// <param name="character">The character we want to get a point array for.</param>
        /// <returns>Returns a point array for the given character. Always returns a valid array.</returns>
        private static PointArray GetPointArray(char character)
        {
            if (SYMBOLS.ContainsKey(character))
                return SYMBOLS[character];

            return POINTS_UNKNOWN;
        }

        /// <summary>
        /// Helper method for checking whether a float is within a specified range.
        /// </summary>
        /// <param name="value">The value we want to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <param name="includeLimits">Should the minimum and maximum values be included in the range?</param>
        /// <returns>Returns true if the value is within the specified range. Returns false otherwise.</returns>
        private static bool IsInRange(float value, float min, float max, bool includeLimits = true)
        {
            if (includeLimits)
                return value >= min && value <= max;
            else
                return value > min && value < max;
        }
        #endregion
    }
}
