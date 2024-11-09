namespace Code.Runtime.Infrastructure.Services
{
    internal sealed class RandomService: IRandomService
    {
        public float Range(float minInclusive, float maxInclusive) =>
            UnityEngine.Random.Range(minInclusive, maxInclusive);
    }
}