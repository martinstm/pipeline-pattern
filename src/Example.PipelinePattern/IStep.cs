using System.Threading.Tasks;

namespace Example.PipelinePattern
{
    public interface IStep
    {
        Task<IData> ExecuteAsync(IData data);
    }
}
