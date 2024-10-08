using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonChange : MonoBehaviour
{
    public void OnButtonChangeCharacter(int num)
    {
        GameManager._instance.ChangeCharacter(num);
        DataManager._instance.ChangeCharacterAnim();
    }

    public void OnButtonChangeName(TMP_InputField inputField)
    {
        if (string.IsNullOrEmpty(inputField.text))
        {
            Debug.LogError("이름을 입력하세요.");
            return;
        }
        GameManager._instance._userName.Clear();
        GameManager._instance._userName.Append(inputField.text);
        DataManager._instance.ChangeUserName();

        inputField.text = string.Empty;
    }

    public void OnButtonSetActive(GameObject obj)
    {
        if (!obj.activeSelf)
            obj.SetActive(true);
        else
            obj.SetActive(false);
    }
}
