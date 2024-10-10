using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepInteraction : MonoBehaviour
{
    private readonly string TAG = "NPC";

    [SerializeField]
    private GameObject _intercationWindow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(TAG))
        {
            CharacterStatHandler handler = collision.GetComponent<CharacterStatHandler>();
            _intercationWindow.GetComponent<InteractionSetting>().SetHandler(handler);
            _intercationWindow.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(TAG))
        {
            _intercationWindow.SetActive(false);
        }
    }
}
