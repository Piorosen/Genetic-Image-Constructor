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


        public static int MutationPointSize = 1;

        // 변이률
        public static double Mutation = 0.01;
        // 생존 갯수
        public static int Survive = 10;

        // 테스트할 케이스
        public static int Count = 50;

        // 교배할 상위종 갯수
        public static int CrossCount = 3;
    }
    public enum ColorType
    {
        GRAY,
        RED,
        GREEN,
        BLUE,
    }
}
