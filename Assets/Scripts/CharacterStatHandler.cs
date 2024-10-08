using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatHandler : MonoBehaviour
{
    [SerializeField]
    private CharacterStat _baseStats;

    private void Awake()
    {
        if(string.IsNullOrEmpty(_baseStats.infoSO.userName))
            _baseStats.userName = _baseStats.infoSO.userName;
    }

    public void SetUserName(string name)
    {
        _baseStats.userName = name;
    }

    public CharacterStat GetBaseStats()
    {
        return _baseStats;
    }
}
