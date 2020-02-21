using System;

namespace ConsoleApp2
{
    class Banknote
    {
        public int SeriesAndNumber { get; set; }
        private int faceValue;
        public string ParValue { get; set; }

        public int  FaceValue
        {
            get => faceValue;
            set
            {
                if (value > 0)
                    faceValue = value;
                else
                {
                    Console.WriteLine("Ошибка: введено не верное значение.");
                    return;
                }
            }
        }

        public Banknote(int seriesAndNumber, int faceValue, string parValue)
        {
            SeriesAndNumber = seriesAndNumber;
            FaceValue = faceValue;
            ParValue = parValue;
        }

        public override string ToString() => $"Банкнота: {SeriesAndNumber}, {FaceValue}, {ParValue}";
    }
}
