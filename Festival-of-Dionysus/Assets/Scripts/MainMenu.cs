using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
	{
		Application.Quit();
		Debug.Log("Game Quit");
	}

	public void LoadHubWorld()
	{
		{
			SceneManager.LoadScene(1);
		}
	}

}
