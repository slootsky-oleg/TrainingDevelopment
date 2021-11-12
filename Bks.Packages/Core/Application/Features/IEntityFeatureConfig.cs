namespace Bks.Packages.Core.Application.Features
{
    public interface IEntityFeatureConfig
    {
        void ValidateFeature<T>(string feature);
    }
}