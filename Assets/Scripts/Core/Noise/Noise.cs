namespace Core.Noise
{
    public abstract class Noise: INoise
    {
        public abstract float [,] GetNoiseMap(int width, int height, float scale = 1);



    }
}