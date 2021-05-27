using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRenting_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRenting_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            DBControls controls = new DBControls();
            if (controls.getCopies(1) > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            DBControls controls = new DBControls();
            if (controls.getCost(1) > 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}