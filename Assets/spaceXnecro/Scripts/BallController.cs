using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    private void GoBall()
    {
        float rand = Random.RandomRange(0, 2);
        if (rand < 1) rb2d.AddForce(new Vector2(20, -15));
        else rb2d.AddForce(new Vector2(-20, -15));

    }

    private void ResetBall()
    {
        //Debug.Log("ResetBall!");
        rb2d.velocity = Vector2.zero;
        transform.position = new Vector2(0,0);
    }

    private void RestartGame()
    {
        Debug.Log("Restart!");
        ResetBall();
        Invoke("GoBall", 2);
    }
}
