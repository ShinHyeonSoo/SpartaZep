using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShowUser : MonoBehaviour
{


    public void OnButtonSetActive(GameObject obj)
    {
        if (!obj.activeSelf)
            obj.SetActive(true);
        else
            obj.SetActive(false);
    }
}
