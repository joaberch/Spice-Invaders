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
    public class AmmoTests
    {
        [TestMethod()]
        public void moveTest()
        {
            //Arrange
            Ammo ammo = new Ammo(1, 100);
            int last_y_position = ammo.y_position;

            //Act
            ammo.move();

            //Assert
            Assert.AreEqual(last_y_position, ammo.y_position+1);
        }
    }
}