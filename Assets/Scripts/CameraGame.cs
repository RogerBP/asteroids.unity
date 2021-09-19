using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGame : MonoBehaviour
{
    public static CameraGame instance;
    public Camera GameCamera;
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        
    }
}
