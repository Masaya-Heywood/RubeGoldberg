using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Up : MonoBehaviour
{
    public Vector2 upwardMoveDistance = new Vector2(0, 10f);
    public Vector2 velocity = new Vector2(1.75f, 1.1f);
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        //upwardTargetedPosition = transform.position + upwardMoveDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.MovePosition(rb2D.position + velocity * Time.deltaTime);
            //transform.position = Vector3.MoveTowards(transform.position, upwardTargetedPosition, upwardSpeed);
            //Debug.Log("I'm active");
        }
    }
}
