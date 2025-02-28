﻿using System.Security.Cryptography;

namespace TouRPGProject.Clases
{
    public static class CalculosRPG
    {
        public static Enum GenerarSeleccionEnumRandom(this Type t)
        {
            return Enum.GetValues(t).OfType<Enum>().OrderBy(e => Guid.NewGuid()).FirstOrDefault();
        }

        public static int GenerarNumeroSuperRandom(int min, int max)
        {
            int num = min - 1;

            RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider();
            byte[] rno = new byte[4];
            rg.GetBytes(rno);
            int randomvalue = BitConverter.ToInt32(rno, 0);
            num = randomvalue / 5 - 1;
            Random rnd = new Random();
            if (rnd.Next(Math.Abs(num)) % 2 == 0)
            {
                num = rnd.Next(Math.Abs(num));
            }
            else
            {
                num = rno[0] / (rno[3] + 1) * rnd.Next(Math.Abs(max));
            }

            return num;
        }
    }
}
