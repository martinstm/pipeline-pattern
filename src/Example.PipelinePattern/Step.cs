using System.Threading.Tasks;

namespace Example.PipelinePattern
{
    public abstract class Step : IStep
    {
        public abstract Task<IData> ExecuteAsync(IData data);
    }
}
