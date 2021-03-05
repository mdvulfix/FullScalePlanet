namespace Core.Noise
{
    public interface INoise
    {
        float [,] GetNoiseMap(int width, int height, float scale = 1);

    }
}