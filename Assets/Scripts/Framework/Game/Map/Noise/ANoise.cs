namespace Game.Map
{
    public abstract class ANoise
    {
        public float[,] noise;
        public abstract float [,] Get(int width, int height, float scale);

    }
}