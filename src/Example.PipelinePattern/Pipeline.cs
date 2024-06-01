using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.PipelinePattern
{
    public class Pipeline<T> : IPipeline<T> where T : IData
    {
        private readonly List<IStep> _steps = new();
        public string Name { get; set; }
        public IReadOnlyCollection<IStep> Steps => _steps;

        public Pipeline(string name)
        {
            Name = name;
        }

        public void WithStep(IStep step)
        {
            _steps.Add(step);
        }

        public async Task<T> StartAsync(IData input)
        {
            IData result = input;
            foreach (var step in Steps)
            {
                try
                {
                    result = await step.ExecuteAsync(result);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return (T)result;
        }
    }
}
