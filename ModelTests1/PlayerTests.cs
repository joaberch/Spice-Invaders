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
    public class PlayerTests
    {
        [TestMethod()]
        public void MovingLeftTest()
        {
            //Arrange
            Player player = new Player();
            Random random = new Random();
            int rdn = random.Next(0, 30);
            int last_x_position;
            int x_position;

            //Act

            //making the player move a random amount of time
            for (int o = 0; o < rdn; ++o)
            {
                player.MovingRight();
            }

            //taking the position before moving to the left
            last_x_position = player.x_position;

            //Moving to the left
            player.MovingLeft();

            //taking the position after moving to the left
            x_position = player.x_position;

            //Assert
            if (last_x_position > 0)
            {
                Assert.AreEqual(last_x_position, player.x_position + 1);  //if it has moved to the right
            }
            else
            {
                Assert.AreEqual(last_x_position, player.x_position);
            }
        }

        [TestMethod()]
        public void MovingRightTest()
        {
            //Arrange
            Player player = new Player();
            int last_x_position;
            int x_position;

            //Act
            last_x_position=player.x_position;
            player.MovingRight();
            x_position = player.x_position;

            //Assert
            Assert.IsTrue(x_position == last_x_position+1);
        }
    }
}