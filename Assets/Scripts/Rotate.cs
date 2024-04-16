using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotatespeed = 80f;
    public Vector3 Axis = Vector3.forward;

    void Update()
    {
        transform.Rotate(Axis, rotatespeed * Time.deltaTime);
    }

}
