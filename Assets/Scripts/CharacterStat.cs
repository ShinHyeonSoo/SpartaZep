using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CharacterStat
{
    [Range(1f, 20f)]
    public float health;
    public string userName;
    public InfoSO infoSO;
}
