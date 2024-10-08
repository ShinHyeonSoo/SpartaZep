using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _userNameText;

    private void Start()
    {
        _userNameText.text = GameManager._instance._userName.ToString();
    }
}
