using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecctGame : MonoBehaviour
{
	//버튼 클릭 이벤트...
	public void OnClickOthrllo()
	{
		SceneManager.LoadScene("scenes/3Game-othello");
	}
	public void OnClickTicTacToe()
	{
		SceneManager.LoadScene("scenes/4Game-TicTakToe");
	}
	public void OnClickBaduk()
	{
		SceneManager.LoadScene("scenes/5Game-baduk");
	}
}
