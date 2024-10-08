using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _characterObjParent;
    private List<GameObject> _characterList = new List<GameObject>();

    private void Start()
    {
        foreach (Transform child in _characterObjParent.transform)
        {
            _characterList.Add(child.gameObject);
        }
    }

    public void OnButtonJoin(TMP_InputField inputField)
    {
        string userName = inputField.text;
        if (string.IsNullOrEmpty(userName))
        {
            Debug.LogError("이름을 입력하세요.");
            return;
        }

        GameManager._instance._userName.Append(userName);

        SceneManager.LoadSceneAsync("Game");
    }

    public void OnButtonChangeImageSetActive(GameObject obj)
    {
        if (!obj.activeSelf)
            obj.SetActive(true);
        else
            obj.SetActive(false);
    }

    public void OnButtonChangeImage(int num)
    {
        GameManager._instance.CharacterType = (Utils.CharacterType)num;

        int count = 0;
        foreach(GameObject go in _characterList)
        {
            if (count == num)
                go.SetActive(true);
            else
                go.SetActive(false);

            ++count;
        }
    }
}
