using UnityEngine;
using System.Collections;

public class HomeScreen : MonoBehaviour 
{
	public string CurrentMenu;
	
	void Start()
	{
		CurrentMenu = "Main";
	}
	
	void OnGUI()
	{
		if (CurrentMenu == "Main")
			Menu_Main ();
		
		if (CurrentMenu == "Singleplayer")
			Menu_Singleplayer ();
		
		if (CurrentMenu == "Multiplayer")
			Menu_Multiplayer ();
		
		if (CurrentMenu == "Stats")
			Menu_Stats ();
		
		if (CurrentMenu == "Credits")
			Menu_Credits ();
	}
	
	public void NavGate (string nextmenu)
	{
		CurrentMenu = nextmenu;
	}
	
	private void Menu_Main()
	{
		if (GUI.Button (new Rect (10, 10, 200, 50), "Singleplayer")) 
		{
			NavGate ("Singleplayer");
		}
		
		if (GUI.Button (new Rect (10, 70, 200, 50), "Multiplayer")) 
		{
			NavGate ("Multiplayer");
		}
		
		if (GUI.Button (new Rect (10, 130, 200, 50), "Stats")) 
		{
			NavGate ("Stats");
		}
		
		if (GUI.Button (new Rect (10, 190, 200, 50), "Credits")) 
		{
			NavGate ("Credits");
		}
	}
	
	private void Menu_Singleplayer()
	{
		if (GUI.Button (new Rect (10, 70, 200, 50), "Back")) 
		{
			NavGate ("Main");
		}
		
		if (GUI.Button (new Rect (10, 10, 200, 50), "Start Game")) 
		{
			Application.LoadLevel("Map1");
		}
	}
	
	private void Menu_Multiplayer()
	{
		if (GUI.Button (new Rect (10, 70, 200, 50), "Back")) 
		{
			NavGate ("Main");
		}
		
		if (GUI.Button (new Rect (10, 10, 200, 50), "Start Game")) 
		{
			Application.LoadLevel("Map1");
		}
	}
	
	private void Menu_Stats()
	{
		if (GUI.Button (new Rect (10, 10, 200, 50), "Back")) 
		{
			NavGate ("Main");
		}
	}
	
	private void Menu_Credits()
	{
		if (GUI.Button (new Rect (10, 10, 200, 50), "Back")) 
		{
			NavGate ("Main");
		}
	}
	
}
