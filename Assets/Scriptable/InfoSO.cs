using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultInfoSO", menuName = "ZepController/Info/Default", order = 0)]
public class InfoSO : ScriptableObject
{
    [Header("Info")]
    public string userName;
    public float speed;
}
