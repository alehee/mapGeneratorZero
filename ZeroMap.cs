using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Newtonsoft.Json.Linq;

namespace mapGeneratorZero
{
    class ZeroColor
    {
        public Color colorTrees = Color.DarkGreen;
        public Color colorStones = Color.Gray;
    }

    class ZeroMap
    {
        bool separated;
        int mapHeight;
        int mapWidth;
        List<Tuple<string, Color, int, bool, bool>> biomes;
        List<ZeroCell> chunks;
        Bitmap mapBitmap;

        public ZeroMap(bool sep, int hei, int wid, List<Tuple<string, Color, int, bool, bool>> bios)
        {
            separated = sep;
            mapHeight = hei;
            mapWidth = wid;
            biomes = bios;
        }

        Tuple<bool, string> generateMap()
        {

            return Tuple.Create(true, "");
        }
    }

    class ZeroCell
    {
        ZeroColor zeroColor = new ZeroColor();
        string biomeName;
        Color biomeColor;
        bool isTrees;
        bool isStones;
        int chunkSide = 8;
        int row;
        int col;

        public ZeroCell(string bio, Color bioC, bool isT, bool isS, int r, int c)
        {
            biomeName = bio;
            biomeColor = bioC;
            isTrees = isT;
            isStones = isS;
            row = r;
            col = c;
        }
    }

    class ZeroObject
    {

    }
}
