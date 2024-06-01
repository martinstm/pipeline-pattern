using Demos.PipelinePattern.Models;
using Example.PipelinePattern;
using System.Threading.Tasks;

namespace Demos.PipelinePattern.Steps
{
    public class ToUpperStep : Step
    {
        public override Task<IData> ExecuteAsync(IData data)
        {
            var input = data as InputData;
            IData output = new OutputData
            {
                Text = input.Text.ToUpper()
            };
            return Task.FromResult(output as IData);
        }
    }
}
