using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonJoin : MonoBehaviour
{
    public TMP_InputField _inputField;

    public void OnButtonJoin()
    {
        string userName = _inputField.text;
        if (string.IsNullOrEmpty(userName))
        {
            Debug.LogError("�̸��� �Է��ϼ���.");
            return;
        }

        GameManager._instance._userName.Append(userName);

        // TODO : �̹�������, �� �̵�
        SceneManager.LoadSceneAsync("Game");
    }
}
