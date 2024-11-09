namespace Code.Runtime.Infrastructure.Services
{
    public interface IRandomService
    {
        float Range(float minInclusive, float maxInclusive);
    }
}