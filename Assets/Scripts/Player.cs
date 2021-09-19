using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigBody;
    public Rigidbody2D bullet;
    public float aceleracao = 1.0f;
    public float velocidadeAngular = 180.0f;
    public float velocidadeMaxima = 2.0f;
    public SpriteRenderer sprite;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D b = Instantiate(bullet, rigBody.position, Quaternion.identity);
            b.velocity = transform.up * 10.0f;
            Destroy(b.gameObject, 1.0f);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direcao = transform.up * aceleracao;
            rigBody.AddForce(direcao, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))rigBody.rotation += velocidadeAngular * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))rigBody.rotation -= velocidadeAngular * Time.deltaTime;
        if (rigBody.velocity.magnitude > velocidadeMaxima)rigBody.velocity = Vector2.ClampMagnitude(rigBody.velocity, velocidadeMaxima);
    }

}
