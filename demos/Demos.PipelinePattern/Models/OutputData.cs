using Example.PipelinePattern;

namespace Demos.PipelinePattern.Models
{
    public class OutputData : IData
    {
        public string Text { get; set; }
        public int Result { get; set; }
    }
}
