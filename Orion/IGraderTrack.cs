using System.Collections;

namespace Orion
{
    internal interface IGraderTrack : IEnumerable
    {

        ComputeStatistics ComputeStatistics();
        void AddGrade(float grade);
        string Name { get; set; }

    }
}