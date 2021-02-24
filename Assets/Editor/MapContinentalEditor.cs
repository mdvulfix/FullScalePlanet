using UnityEngine;
using UnityEditor;
using Source.Map;

[CustomEditor (typeof (MapContinental))]
public class MapContinentalEditor : Editor 
{

	public override void OnInspectorGUI() 
	{
		
		base.OnInspectorGUI();
		MapContinental mapContinental = (MapContinental)target;
		/*
		if (DrawDefaultInspector ())
		{
			if (mapController.autoUpdate) 
			{
				mapController.CreateMap ();
			}
		}
		*/
		if (GUILayout.Button ("Generate")) 
		{
			mapContinental.Generate();
		}
	}
}