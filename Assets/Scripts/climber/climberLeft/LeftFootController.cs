using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFootController : MonoBehaviour
{

    private bool dragging = false;
    private float distance;

    public Rigidbody Ball;
    public float Speed = 100;

    Vector3 initialPosition;

    void Update()
    {
        // called the first time mouse button is pressed
        if (Input.GetMouseButtonDown(0) && Input.GetButton("Jump"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //initialPosition = transform.position;

            Vector3 rayPoint = ray.GetPoint(0);

            // Not sure but this might get you a slightly better value for distance
            distance = Vector3.Distance(transform.position, rayPoint);
        }

        // called while button stays pressed
        if (Input.GetMouseButton(0) && Input.GetButton("Jump"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            Ball.MovePosition(initialPosition + new Vector3(rayPoint.x, rayPoint.y, 0));
        }
    }
}
