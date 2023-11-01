using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tests
{
    [TestClass()]
    public class ScoreTests
    {
        [TestMethod()]
        public void AddScoreTest()
        {
            //Arrange
            Score score = new Score();
            score.score = 10;
            Random random = new Random();
            int last_score;

            //Act & Assert
            for (int i = 0; i < 100; ++i)
            {
                last_score = score.score;
                int rdn = random.Next(1, 10);
                score.AddScore(rdn);

                Assert.IsTrue(score.score == last_score + rdn * 10);
            }
        }
    }
}