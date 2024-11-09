namespace Code.Runtime.Infrastructure.Services.Random
{
    internal sealed class RandomService: IRandomService
    {
        public float Range(float minInclusive, float maxInclusive) =>
            UnityEngine.Random.Range(minInclusive, maxInclusive);
    }
}