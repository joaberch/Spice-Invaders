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
    public class EnemyTests
    {
        [TestMethod()]
        public void moveTest()
        {
            //Arrange
            Enemy enemy = new Enemy(1, 1);
            int last_x_position;
            int x_position;

            //Act & Assert
            for (int i = 0; i < 100; ++i)
            {
                if (enemy._x_position >= 3 || enemy._x_position < 1)
                {
                    enemy.moveDown();
                }

                last_x_position = enemy._x_position;
                enemy.move();
                x_position = enemy._x_position;


                if (enemy.IsItGoingToTheRight)
                {
                    Assert.AreEqual(x_position, last_x_position + 1);
                }
                else
                {
                    Assert.AreEqual(x_position + 1, last_x_position);
                }
            }

        }

        [TestMethod()]
        public void moveDownTest()
        {
            //Arrange
            Enemy enemy = new Enemy(1, 1);
            bool isRightBefore = enemy.IsItGoingToTheRight;
            int last_y_position = enemy._y_position;

            //Act
            enemy.moveDown();

            //Assert
            Assert.AreEqual(last_y_position + 1, enemy._y_position);
            Assert.AreNotEqual(isRightBefore, enemy.IsItGoingToTheRight);
        }

        [TestMethod()]
        public void takeDamageTest()
        {
            //Arrange
            Enemy enemy = new Enemy(1, 10);
            int last_nbr_life = enemy._Enemy_lifePoint;

            //Act
            enemy.takeDamage();

            //Assert
            Assert.AreEqual(enemy._Enemy_lifePoint + 1, last_nbr_life);
        }
    }
}