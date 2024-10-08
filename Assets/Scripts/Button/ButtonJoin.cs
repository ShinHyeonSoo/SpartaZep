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
            Debug.LogError("이름을 입력하세요.");
            return;
        }

        GameManager._instance._userName.Append(userName);

        // TODO : 이미지저장, 씬 이동
        SceneManager.LoadSceneAsync("Game");
    }
}
