using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public StringBuilder _userName = new StringBuilder();

    public Utils.CharacterType CharacterType { get; private set; }

    private void Start()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void ChangeCharacter(int num)
    {
        CharacterType = (Utils.CharacterType)num;
    }
}
