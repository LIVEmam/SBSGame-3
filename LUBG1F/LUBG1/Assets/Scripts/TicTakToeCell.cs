using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTakToeCell : MonoBehaviour
{
	public Text targetText;
	public eStste currentState;
	public int x;
	public int y;
	public enum eStste
	{
		None,
		O,
		X,
	}
	private void Start()
	{
		SetState(eStste.None);
	}

	public void SetState(eStste targetState)
	{
		switch(targetState)
		{
			case eStste.None:
				targetText.text = "";
				break;
			case eStste.O:
				targetText.text = "O";
				break;
			case eStste.X:
				targetText.text = "X";
				break;
		}
		currentState = targetState;
	}
}
