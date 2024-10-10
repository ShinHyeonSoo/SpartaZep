using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionSetting : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _nameText;
    [SerializeField]
    private TextMeshProUGUI _scriptText;

    private CharacterStatHandler _handler;

    private void OnEnable()
    {
        _nameText.text = _handler.GetBaseStats().userName;
    }

    public void SetHandler(CharacterStatHandler handler)
    {
        _handler = handler;
    }

    public void OnButtonCall()
    {
        _scriptText.text = _handler.GetBaseStats().infoSO.script;
    }
}
