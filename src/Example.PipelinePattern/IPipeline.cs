using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.PipelinePattern
{
    public interface IPipeline<T>
    {
        public string Name { get; set; }
        public IReadOnlyCollection<IStep> Steps { get; }
        void WithStep(IStep step);
        Task<T> StartAsync(IData data);
    }
}
