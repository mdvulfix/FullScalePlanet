using UnityEngine;
using UnityEditor;
using Source.Map;

[CustomEditor (typeof (AMapGenerator))]
public class AMapGeneratorEditor : Editor 
{

	public override void OnInspectorGUI() 
	{
		AMapGenerator mapGen = (AMapGenerator)target;
		/*
		if (DrawDefaultInspector ())
		{
			if (mapController.autoUpdate) 
			{
				mapController.CreateMap ();
			}
		}
		*/
		if (GUILayout.Button ("Create")) 
		{
			mapGen.CreateMap<MapContinental>(null);
		}
	}
}