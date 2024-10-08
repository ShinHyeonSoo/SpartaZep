using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField]
    private TextMeshProUGUI _userNameText;
    [SerializeField]
    private TextMeshProUGUI _currentTimeText;

    [Header("Animation")]
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

    private void Update()
    {
        _currentTimeText.text = Utils.GetCurrentTime();
    }
}
