using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _userNameText;
    [SerializeField]
    private Animator _playerAnimator;
    [SerializeField]
    private RuntimeAnimatorController[] _animControllers;

    private void Start()
    {
        if (GameManager._instance != null)
        {
            _userNameText.text = GameManager._instance._userName.ToString();
            _playerAnimator.runtimeAnimatorController = _animControllers[(int)GameManager._instance.CharacterType];
        }
    }
}
