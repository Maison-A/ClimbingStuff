using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetailsScript : MonoBehaviour
{
    public Vector2 turn;

    void Update()
    {
        turn.x = Input.GetAxis("Mouse X");
        turn.y = Input.GetAxis("Mouse Y");
    }
}
