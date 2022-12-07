using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTriggers : MonoBehaviour
{
	[SerializeField]
	public GameObject Game1, LabrinthPlayer, Game2, Game3, DefencePlayer;
	public bool isActive;
	public Rigidbody rigidbody;
	public GameObject Player;
	public ThirdPersonCharacterController playerCont;
	
	void Start()
	{

		//Time.timeScale = 1;
	

		Game2.SetActive(false);
		Game1.SetActive(false);
		Game3.SetActive(false);
	}

	


	void OnTriggerEnter(Collider col)
		{
		if (col.tag == "Medusa")
		{
			//LabrinthPlayer.SetActive(true);
			Debug.Log("touching");
			Game2.SetActive(true);
			Cursor.visible = true;
			Screen.lockCursor = false;
			//Player.SetActive(false); <--- This was turning the camera off???
			playerCont.gameOpen = true;
			
		}
		else if (col.tag == "Defend")
		{
			//LabrinthPlayer.SetActive(true);
			Debug.Log("touching");
			Game3.SetActive(true);
			Cursor.visible = true;
			Screen.lockCursor = false;
			//Player.SetActive(false);
			playerCont.gameOpen = true;

		}
		else if (col.tag == "Labrinth")
		{
			//LabrinthPlayer.SetActive(true);
			Debug.Log("touching");
			Game1.SetActive(true);
			Cursor.visible = true;
			Screen.lockCursor = false;
			//Player.SetActive(false);
			playerCont.gameOpen = true;


		}
		else if (col.tag =="LevelSelect")
			{
			SceneManager.LoadScene(1);
			Cursor.visible = true;
			Screen.lockCursor = false;

		}

		else
		{
			Game1.SetActive(false);
			Game2.SetActive(false);
			Game3.SetActive(false);
		}
		}

	


}
