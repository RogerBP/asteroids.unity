using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicionamento : MonoBehaviour
{
    public Rigidbody2D rigBody;
    void Update()
    {
        Camera camera = CameraGame.instance.GameCamera;
        float x = camera.orthographicSize * camera.aspect;
        float y = camera.orthographicSize;
        Vector2 p = rigBody.position;
        if (p.x > x || p.x < -x) p.x *= -1;
        if (p.y > y || p.y < -y) p.y *= -1;
        rigBody.position = p;
    }
}
