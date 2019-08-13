using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{


    Vector2 Movimento;

    public float Velocidade = 5f;

    public Rigidbody2D rb;


    // Update is called once per frame
    void Update()
    {
        Movimento.x = Input.GetAxisRaw("Horizontal");
        Movimento.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movimento * Velocidade * Time.fixedDeltaTime);
    }
}
