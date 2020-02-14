using System;
using BirdHunter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BirdHunter_Test
{
    [TestClass]
    public class BirdHunterTest
    {
        [TestMethod]
        public void PlayGame()
        {
            BirdHunterRepository content = new BirdHunterRepository();
            content.DrofsnarAttacks();
        }
    }
}
