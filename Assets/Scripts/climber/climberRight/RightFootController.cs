using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFootController : MonoBehaviour
{

    private bool dragging = false;
    private float distance;

    public Rigidbody Ball;
    public float Speed = 100;

    Vector3 startPosition;

    void Update()
    {
        // called the first time mouse button is pressed
        if (Input.GetMouseButtonDown(1) && Input.GetButton("Jump"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //initialPosition = transform.position;

            Vector3 rayPoint = ray.GetPoint(0);

            // Not sure but this might get you a slightly better value for distance
            distance = Vector3.Distance(transform.position, rayPoint);
        }

        // called while button stays pressed
        if (Input.GetMouseButton(1) && Input.GetButton("Jump"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            Ball.MovePosition(startPosition + new Vector3(rayPoint.x, rayPoint.y, 0));
        }
    }
    // every time your charicter collides with a rigid body
    // called only on first frame of collision
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("Enter");
        }
    }
    // called every frame of collision
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Stay");
        }
    }
    // called on last frame of collision
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Exit");
        }
    }
    
}
