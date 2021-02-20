using Core;
using Core.Noise;

namespace Source.Map
{
    public interface IMapGenerator
    {
        int     MapWidth  {get;}
        int     MapLength {get;}
        float   MapScale  {get;}

        float[,] MapNoise {get;}
        
        void SetParametrs(int width = 1, int length = 1, float scale = 5f, string massege = null);
        void CreateMap<T>(string massege = null) where T: ASceneObject , IMap, new();

    }
}