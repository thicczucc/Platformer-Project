using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    private bool MovingForward = true;
    public float timer = 5;
    public float walkSpeed = 10;
    private bool canWalk = true;
    private Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canWalk)
        {
            if (MovingForward)
            {
                RB.AddForce(new Vector2(walkSpeed, 0), ForceMode2D.Impulse);
            }
            else
            {
                RB.AddForce(new Vector2(-walkSpeed, 0), ForceMode2D.Impulse);
            }
            StartCoroutine("HoldTimer");
        }
    }
     
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealthManager>().changeHealth(-1);
        }
    }
    IEnumerator HoldTimer()
    {
        if (MovingForward)
        {
            MovingForward = false;
        }
        else
        {
            MovingForward = true;
        }
        canWalk = false;
        yield return new WaitForSeconds(timer);
        canWalk = true;
    }
}

