using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject target;
    public float lerpT;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
        //transform.position = Vector3.Lerp(target.transform.position + offset, transform.position + offset, lerpT);
    }
}
