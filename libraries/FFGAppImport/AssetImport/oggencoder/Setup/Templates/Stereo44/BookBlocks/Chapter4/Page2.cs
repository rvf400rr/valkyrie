﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter4
{
    public class Page2 : IStaticCodeBook
    {
        public int Dimensions = 4;

        public byte[] LengthList = {
            2, 5, 5, 0, 0, 0, 5, 5, 0, 0, 0, 5, 5, 0, 0, 0,
            7, 7, 0, 0, 0, 0, 0, 0, 0, 5, 6, 6, 0, 0, 0, 7,
            7, 0, 0, 0, 7, 7, 0, 0, 0, 10, 10, 0, 0, 0, 0, 0,
            0, 0, 5, 6, 6, 0, 0, 0, 7, 7, 0, 0, 0, 7, 7, 0,
            0, 0, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 5, 8, 7, 0, 0, 0, 7, 7, 0, 0,
            0, 7, 7, 0, 0, 0, 9, 9, 0, 0, 0, 0, 0, 0, 0, 5,
            7, 8, 0, 0, 0, 7, 7, 0, 0, 0, 7, 7, 0, 0, 0, 9,
            9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 5, 7, 7, 0, 0, 0, 7, 7, 0, 0, 0, 7, 7,
            0, 0, 0, 9, 9, 0, 0, 0, 0, 0, 0, 0, 5, 7, 7, 0,
            0, 0, 7, 7, 0, 0, 0, 7, 7, 0, 0, 0, 9, 9, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            7, 10, 10, 0, 0, 0, 9, 9, 0, 0, 0, 9, 9, 0, 0, 0,
            10, 10, 0, 0, 0, 0, 0, 0, 0, 8, 10, 10, 0, 0, 0, 9,
            9, 0, 0, 0, 9, 9, 0, 0, 0, 10, 10, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0
        };

        public CodeBookMapType MapType = CodeBookMapType.Implicit;
        public int QuantMin = -533725184;
        public int QuantDelta = 1611661312;
        public int Quant = 3;
        public int QuantSequenceP = 0;

        public int[] QuantList = {
            2,
            1,
            3,
            0,
            4
        };
    }
}