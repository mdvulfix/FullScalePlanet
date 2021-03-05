using UnityEngine;
using System.Collections;

public static class Noise3 {
	/*
	public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale) {
		float[,] noiseMap = new float[mapWidth,mapHeight];

		if (scale <= 0) {
			scale = 0.0001f;
		}

		for (int y = 0; y < mapHeight; y++) {
			for (int x = 0; x < mapWidth; x++) {
				float sampleX = x / scale;
				float sampleY = y / scale;

				float perlinValue = Mathf.PerlinNoise (sampleX, sampleY);
				noiseMap [x, y] = perlinValue;
			}
		}

		return noiseMap;
	}
	*/
	public static float [,] GenerateNoiseMap(int width, int height, float scale = 1)
	{   
		float[, ] noiseMap = new float[width,height];
		if (scale <=0)
		{
			scale = 0.0001f;
		}

		
		
		for (int y = 0; y < height; y++)
		{
			for (int x = 0; x < width; x++)
			{
				noiseMap[x,y] = Mathf.PerlinNoise(x/scale, y/scale);
			}
		}
		
		return noiseMap;
	}

}