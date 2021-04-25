using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Title : MonoBehaviour
{
	public Text tweenTarget;


	private void Start()
	{
		StartCoroutine(TweenAnimation());
	}

	private void Update()
	{
		if(Input.anyKeyDown == true) //�ƹ�Ű�� ������ ��
		{
			//���� ���þ����� �̵�
			SceneManager.LoadScene("scenes/2SelecectGame");
		}
	}

	//�ڷ�ƾ = ���ʵڽ���
	//����� Update�� (�ݺ���) �ȿ��� �����Ű�� �ȵȴ�.
	private IEnumerator TweenAnimation()
	{
		tweenTarget.color = new Color(tweenTarget.color.r, tweenTarget.color.g, tweenTarget.color.b, 0.5f); //���� 50% ����
		float alpha = tweenTarget.color.a;
		float green = tweenTarget.color.g;

		while(true)
		{
			tweenTarget.color = new Color(tweenTarget.color.r, green, tweenTarget.color.b, alpha);

			yield return null;

			if (alpha >= 1)
			{
				alpha = 0.5f;
				green = 0f;
			}

			alpha += 0.3f * Time.deltaTime;
			green += 0.3f * Time.deltaTime;
		}
	}
}
