using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMov : MonoBehaviour
{
    void Start()
    {
        transform.position += new Vector3(1f * Time.deltaTime, 0.0f, 0.0f);
    }
    void Update()
    {
        transform.position += new Vector3(1f * Time.deltaTime, 0.0f, 0.0f);
    }
}
