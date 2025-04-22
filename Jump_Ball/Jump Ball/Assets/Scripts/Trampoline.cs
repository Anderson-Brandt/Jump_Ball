using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int trampolineForce; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, trampolineForce), ForceMode2D.Impulse);

        }
    }
}
