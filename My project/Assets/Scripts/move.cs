using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //sample
    public float moveSpeed = 5f;
    public float jumpingPower = 6f;
    private float horizontal;
    private float vertical;


    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.F)) {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            wait();
        } else {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 1f);
        }
        


    }
    void FixedUpdate() // updating every reference frame. ie. 60 fps and 24 fps would have the same movement update
    {
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);   
    }

    IEnumerator wait() {
        yield return new WaitForSeconds(1.0f);
    }

}
