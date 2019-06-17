
namespace VideoProcessorModule
{
    #pragma warning disable CS0649
    internal class ModelResponse
    {
        public bool IsEmpty
        {
            get { return bboxes.Length == 0; }
        }
        public int[] classes;
        public double[] scores;
        public double[][] bboxes;
    }
}