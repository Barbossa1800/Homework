using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Lab1
{
    struct InitialData
    {
        public int Speed;
        public int FastSpeed;
        private InitialData(int Speed, int FastSpeed)
        {
            this.Speed = Speed;
            this.FastSpeed = FastSpeed;
        }

        public static InitialData GetInstance(int Speed, int FastSpeed) // новый экземпляр клаза без конструктора(инициализация статических свойств)
        {
            return new InitialData(Speed, FastSpeed);
        }
    }
    public class Data
    {
        const int distance = 40;
        public double MeetingTime()
        {
            var man1 = InitialData.GetInstance(4, 10);
            var man2 = InitialData.GetInstance(3, 7);
            return distance / ((man1.Speed - man1.FastSpeed) / 0.5) - ((man2.Speed - man2.FastSpeed) / 0.6);
        }
    }
}
