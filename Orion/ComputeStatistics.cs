using System;
using System.Runtime.Serialization;

namespace Orion
{
    [Serializable]
    internal class ComputeStatistics : Exception
    {
        public ComputeStatistics()
        {
        }

        public float AvgGrade;
        public float MaxGrade = 0;
        public float MinGrade = float.MaxValue;
    }
}