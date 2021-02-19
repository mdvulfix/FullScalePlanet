using UnityEngine;
using UnityEditor;
using Source.Map;

[CustomEditor (typeof (MapController))]
public class MapControllerEditor : Editor 
{

	public override void OnInspectorGUI() 
	{
		MapController mapController = (MapController)target;

		if (DrawDefaultInspector ())
		{
			if (mapController.autoUpdate) 
			{
				mapController.CreateMap ();
			}
		}

		if (GUILayout.Button ("Create")) 
		{
			mapController.CreateMap ();
		}
	}
}