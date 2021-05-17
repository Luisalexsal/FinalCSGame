using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{

	public GUISkin myskin;

	void OnGUI()
	{
		GUI.skin = myskin;
		if (GUI.Button(new Rect(20, 20, 200, 100), "Menu"))
		{
			Application.LoadLevel(0);
		}
	}
}
