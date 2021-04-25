using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Baduk : MonoBehaviour
{
	public void OnClickTitle()
	{
		SceneManager.LoadScene("scenes/1Title");
	}
}
