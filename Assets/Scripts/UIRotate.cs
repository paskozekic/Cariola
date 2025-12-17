using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIRotate : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.Rotate(new Vector3(0f, speed * Time.deltaTime, 0f));
    }
}
