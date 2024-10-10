using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class DataManager : MonoBehaviour
{
    public static DataManager _instance;

    [Header("User")]
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _users;
    private List<GameObject> _usersList = new List<GameObject>();

    [Header("UI")]
    [SerializeField]
    private TextMeshProUGUI _userNameText;
    [SerializeField]
    private TextMeshProUGUI _currentTimeText;
    [SerializeField]
    private GameObject _userList;

    [Header("Animation")]
    [SerializeField]
    private Animator _playerAnimator;
    [SerializeField]
    private RuntimeAnimatorController[] _animControllers;

    [Header("ObjectPool")]
    [SerializeField]
    private ObjectPool _pool;

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
            _player.GetComponent<CharacterStatHandler>().SetUserName(_userNameText.text);
        }

        foreach (Transform user in _users.transform)
        {
            _usersList.Add(user.gameObject);
        }

        AddUserList("UserName", _usersList.Count);
    }

    private void Update()
    {
        _currentTimeText.text = Utils.GetCurrentTime();
    }

    public void ChangeUserName()
    {
        _userNameText.text = GameManager._instance._userName.ToString();
        _player.GetComponent<CharacterStatHandler>().SetUserName(_userNameText.text);
    }

    public void ChangeCharacterAnim()
    {
        _playerAnimator.runtimeAnimatorController = _animControllers[(int)GameManager._instance.CharacterType];
    }

    public void AddUserList(string key, int num = 1)
    {
        for (int i = 0; i < num; ++i)
        {
            GameObject obj = _pool.CustomSpawnFromPool(key, _userList);
            obj.GetComponent<TextMeshProUGUI>().text = _usersList[i].GetComponent<CharacterStatHandler>().GetBaseStats().userName;
        }
    }
}
