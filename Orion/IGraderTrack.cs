namespace Orion
{
    internal interface IGraderTrack
    {

        ComputeStatistics ComputeStatistics();
        void AddGrade(float grade);
        string Name { get; set; }
    }
}