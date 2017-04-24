using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void DoesComputeStaticsMaxMinCorrectly()
        {
            GradeBook gradeBook = new GradeBook();
            gradeBook.AddGrade(10);
            gradeBook.AddGrade(90);
            ComputeStatistics statics = gradeBook.ComputeStatistics();

            Assert.AreEqual(90, statics.MaxGrade);
            Assert.AreEqual(10, statics.MinGrade);
        }

        [TestMethod]
        public void DoesComputeStaticsAvgCorrectly()
        {
            GradeBook gradeBook = new GradeBook();
            gradeBook.AddGrade(91);
            gradeBook.AddGrade(89.5f);
            gradeBook.AddGrade(75);

            ComputeStatistics statics = gradeBook.ComputeStatistics();
            Assert.AreEqual(85.166, statics.AvgGrade,0.001);
        }
    }
}
