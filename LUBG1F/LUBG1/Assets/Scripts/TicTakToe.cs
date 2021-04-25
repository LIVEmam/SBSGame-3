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
	/// ���� �����״ٰ� �ؾ��ϱ� �����̴�
	/// </summary>
	public GameObject gameResuitPanel;


	/// <summary>
	/// ���� ����ߴ��� �ؽ�Ʈ�� �����ؾ��ϱ� �����̴�.
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
	/// ���Ӱ���� Ȯ���ϴ� �޼ҵ�
	/// </summary>

	private void CheckResuit(TicTakToeCell cell)
	{
		//���޾� none�ƴ� state���� üũ�ط���
		//�׷������� �ʿ��� ������ ? ������ ��ġ��, ���° ĭ�� �ִ���.

			int sameCount = 0;

			for (int x = -2; x <= 2; x++) //�¿���ΰ˻�
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

			for (int y = -2; y <= 2; y++) //���϶��� �˻�
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
