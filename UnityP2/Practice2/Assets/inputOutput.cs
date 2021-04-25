using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputOutput : MonoBehaviour
{
    int i = 0;

    // 스크립트가 시작될때 한번 호출됩니다.
    void Start()
    {
        Debug.Log("일반 로그");
        Debug.LogWarning("경고 로그");
        Debug.LogError("에러 로그");
    }

    // 매 프래임마다 호출됩니다. e.g)  1000fps -> 1초에 1000번 실행 / 6fps -> 1초에 60번실행
    void Update()
    {
		// 해당키가 눌려져있는지?
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
        Debug.Log($"버튼이 {i++}회 눌렸습니다.");
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
