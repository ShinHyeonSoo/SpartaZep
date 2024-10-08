using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager _instance;

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

    private void Awake()
    {
        if(_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

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

    public void ChangeUserName()
    {
        _userNameText.text = GameManager._instance._userName.ToString();
    }

    public void ChangeCharacterAnim()
    {
        _playerAnimator.runtimeAnimatorController = _animControllers[(int)GameManager._instance.CharacterType];
    }
}
