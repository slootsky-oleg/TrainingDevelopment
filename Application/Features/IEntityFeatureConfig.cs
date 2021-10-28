namespace Bks.Training.Development.Application.Features
{
    public interface IEntityFeatureConfig
    {
        void ValidateFeature<T>(string feature);
    }
}