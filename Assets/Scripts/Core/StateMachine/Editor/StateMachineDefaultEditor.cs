using UnityEngine;
using UnityEditor;
using Core;

[CustomEditor (typeof (StateMachineDefault))]
public class StateMachineDefaultEditor : Editor 
{

	public override void OnInspectorGUI() 
	{
		
		base.OnInspectorGUI();
		StateMachineDefault stateMachine = (StateMachineDefault)target;
	        
      GUILayout.BeginHorizontal();
      if (GUILayout.Button ("Prev")) 
		{
			//stateMachine.SetState<Load>(name: "State: Load");
		}
		
		if (GUILayout.Button ("Next")) 
		{
			//stateMachine.SetState<Streem>(name: "State: Streem");
		}
        GUILayout.EndHorizontal();
	}

}
