using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float scaleMargin = 0.1f;

    private void Update()
    {
        var gameCamera = CameraGame.instance;
        var maxY = gameCamera.GameCamera.orthographicSize;
        var maxX = maxY * gameCamera.GameCamera.aspect;
        var spriteExtents = (Vector2)spriteRenderer.sprite.bounds.extents;
        var scaleX = maxX / spriteExtents.x;
        var scaleY = maxY / spriteExtents.y;
        var scale = Mathf.Max(scaleX, scaleY) + scaleMargin;
        transform.localScale = new Vector3(scale, scale, 1.0f);
    }
}