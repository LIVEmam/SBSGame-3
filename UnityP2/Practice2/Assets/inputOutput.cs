using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputOutput : MonoBehaviour
{
    int i = 0;

    // ��ũ��Ʈ�� ���۵ɶ� �ѹ� ȣ��˴ϴ�.
    void Start()
    {
        Debug.Log("�Ϲ� �α�");
        Debug.LogWarning("��� �α�");
        Debug.LogError("���� �α�");
    }

    // �� �����Ӹ��� ȣ��˴ϴ�. e.g)  1000fps -> 1�ʿ� 1000�� ���� / 6fps -> 1�ʿ� 60������
    void Update()
    {
		// �ش�Ű�� �������ִ���?
        if(Input.GetKeyDown(KeyCode.A) == true)
		{
            Debug.Log("A dwon");
		}
        if(Input.GetKey(KeyCode.S) == true)
        {
            Debug.Log("S");
        }
        if(Input.GetKeyUp(KeyCode.D) == true)
        {
            Debug.Log("D up");
        }
    }

    public void OnClickButton()
	{
        Debug.Log($"��ư�� {i++}ȸ ���Ƚ��ϴ�.");
	}

    public void OnChangeSliderValue(Slider sender)
	{
        Debug.Log($"ChangeValue - {sender.value}");
	}

    public void OnChangeSrollBarValue(Scrollbar sender)
	{
        Debug.Log($"[ScrollBar] ChageValue - {sender.value}");
	}

    public void OnChangeDDBoxValue(Dropdown sender)
	{
        Debug.Log($"[DropDownBox] ChageValue - {sender.value}");
	}

    public void OnChangeInputFieldValue(InputField sender)
	{
        Debug.Log($"[InputField] ChangValue - {sender.text}");
	}
    public void OnEndInputFieldValue(InputField sender)
    {
        Debug.Log($"[InputField] EndEdit - {sender.text}");
    }
}
