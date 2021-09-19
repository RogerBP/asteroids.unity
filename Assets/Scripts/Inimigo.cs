using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Inimigo : MonoBehaviour
{
    public static Action<int> onDestroyInimigo = null;

    public ExplosiontEfectBehavior explosion;
    public Rigidbody2D rigBody;
    public Inimigo novoInimigo;
    public int fragmentos = 0;
    public int pontos = 100;

    void Start()
    {
        rigBody.velocity = Random.insideUnitCircle;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (onDestroyInimigo != null) onDestroyInimigo(pontos);
        Destroy(gameObject);
        Destroy(c.gameObject);
        for (var i = 0; i < fragmentos; i++) Instantiate(novoInimigo, rigBody.position, Quaternion.identity);
        Instantiate(explosion, rigBody.position, Quaternion.identity);
    }
}
