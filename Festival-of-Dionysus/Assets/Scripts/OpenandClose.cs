using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenandClose : MonoBehaviour
{
	public GameObject Panel;

	private void Awake()
	{
		Panel.SetActive(false);
	}
}