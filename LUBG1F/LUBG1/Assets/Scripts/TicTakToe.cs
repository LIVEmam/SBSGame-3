using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TicTakToe : MonoBehaviour
{
	public void OnClickTitle()
	{
		SceneManager.LoadScene("scenes/1Title");
	}


	/// <summary>
	/// 예를 껏다켰다가 해야하기 때문이다
	/// </summary>
	public GameObject gameResuitPanel;


	/// <summary>
	/// 누가 우승했는지 텍스트를 수정해야하기 때문이다.
	/// </summary>
	public Text gameResuitVictoryText;

    bool isTurnO = true;
	private TicTakToeCell[,] cells = new TicTakToeCell[3,3];

	private void Start()
	{
		gameResuitPanel.SetActive(false);
	}

	public void Gameover()
	{
		gameResuitVictoryText.text = string.Format(gameResuitVictoryText.text, isTurnO == true ? "O" : "X");
		gameResuitPanel.SetActive(true);
	}

	public void OnClickCell(TicTakToeCell cell)
	{
		if (cell.currentState != TicTakToeCell.eStste.None)
		{
			return;
		}
		if(isTurnO == true)
		{
			cell.SetState(TicTakToeCell.eStste.O);
		}
		else//false
		{
			cell.SetState(TicTakToeCell.eStste.X);
		}
		cells[cell.x, cell.y] = cell;

		CheckResuit(cell);

		isTurnO = !isTurnO;
	}

	/// <summary>
	/// 게임결과를 확인하는 메소드
	/// </summary>

	private void CheckResuit(TicTakToeCell cell)
	{
		//연달아 none아닌 state인지 체크해랴함
		//그러기위해 필요한 데이터 ? 셀들의 위치값, 몇번째 칸에 있는지.

			int sameCount = 0;

			for (int x = -2; x <= 2; x++) //좌우라인검사
			{
				if(cell.x + x < 0 || cell.x + x > 2 || cells[cell.x + x, cell.y] == null)
					continue;


				if (cells[cell.x + x, cell.y].currentState == cell.currentState)
				{
					sameCount += 1;
				}
			}
			if(sameCount >= 3)
			{
				Gameover();
				return;
			}

		    sameCount = 0;

			for (int y = -2; y <= 2; y++) //상하라인 검사
			{
				if (cell.y + y < 0 || cell.y + y > 2 || cells[cell.x, cell.y + y] == null)
					continue;


				if (cells[cell.x, cell.y + y].currentState == cell.currentState)
				{
					sameCount += 1;
				}
			}
			if (sameCount >= 3)
			{
				Gameover();
				return;
			}
	}
}
