using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Global
    {
        public static Size OriginImageSize = new Size(256, 256);
        public static Size GeneticCutCount = new Size(16, 16);

        public static bool GrayScale = true;

        public static bool MutationRangeRandom = false;
        public static bool MutationOver = false;

        public static int MutationPointSize = 5;

        public static int MutationMaxCount = 20;

        // 변이률
        public static double Mutation = 0.3;

        public static CrossType CrossType = CrossType.Random;

        // 테스트할 케이스
        public static int Count = 50;

        // 교배할 상위종 갯수
        public static int EliteSurvive = 2;
    }

    public enum CrossType : int
    {
        Vertical = 1,
        Horizontal = 2,
        Random = 4
    }
    public enum ColorType
    {
        GRAY,
        RED,
        GREEN,
        BLUE,
    }
}
