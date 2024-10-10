using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    public bool IsDetected { get; set; }

    private void LateUpdate()
    {
        CameraMove();
    }

    private void CameraMove()
    {
        if(IsDetected) return;
            transform.position = new Vector3(_target.transform.position.x, _target.transform.position.y, transform.position.z);
    }
}
