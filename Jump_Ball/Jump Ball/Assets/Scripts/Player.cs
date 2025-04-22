using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private bool isJumping;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(speed, rig.velocity.y);
        Jump();
    }

    void Jump()
    {
        if (Input.GetMouseButtonDown(0) && !isJumping)
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
            AudioController.instance.PlayMusic(AudioController.instance.jump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            isJumping = false;
        }

        if(collision.gameObject.layer == 7)
        {
            GameControll.instance.ShowFinalGame();
        }

        if (collision.gameObject.layer == 8)
        {
            GameControll.instance.ShowGameOver();
        }
    }
}
