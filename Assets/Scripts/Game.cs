using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Inimigo inimigo;

    void Start()
    {
        for (int i = 1; i <= 3; i++)
        {
            var x = Random.Range(-7, 7);
            var y = Random.Range(-4, 4);
            Vector3 pos = new Vector3(x, y, 0);
            Instantiate(inimigo, pos, Quaternion.identity);
        }
    }
}
