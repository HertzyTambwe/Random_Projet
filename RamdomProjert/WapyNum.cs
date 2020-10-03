using System;

namespace RamdomProjert
{
    public class WapyNum
    {
        private const string chaineNuber = "abcdefghijklmnopqrstuvwxyz1234567890";
        private string chaineRandom;
        public char Nuber1
        {
            get
            {
                return chaineRandom[random.Next(chaineRandom.Length)];
            }
        }
        public char Nuber2
        {
            get
            {
                return chaineRandom[random.Next(chaineRandom.Length)];
            }
        }
        public char Nuber3
        {
            get
            {
                return chaineRandom[random.Next(chaineRandom.Length)];
            }
        }
        public char Nuber4
        {
            get
            {
                return chaineRandom[random.Next(chaineRandom.Length)];
            }
        }
        private Random random;

        public WapyNum()
        {
            Initialisateur();
        }

        private void Initialisateur()
        {
            random = new Random();
            for (int i = 0; i < chaineNuber.Length; i++)
            {
                chaineRandom += chaineNuber[random.Next(chaineNuber.Length)];
            }
        }
    }
}
