using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnotherScreen : MonoBehaviour
{
	public GameObject ScreenToDicable;
	public GameObject ScreenToEnable;

	public void Open ()
	{
		ScreenToDicable.SetActive (false);
		ScreenToEnable.SetActive (true);
	}
}
