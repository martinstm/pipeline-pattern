using Demos.PipelinePattern.Models;
using Example.PipelinePattern;
using System.Threading.Tasks;

namespace Demos.PipelinePattern.Steps
{
    public class TextLengthStep : Step
    {
        public override Task<IData> ExecuteAsync(IData data)
        {
            var input = data as OutputData;
            input.Result = input.Text.Length;
            return Task.FromResult(input as IData);
        }
    }
}
