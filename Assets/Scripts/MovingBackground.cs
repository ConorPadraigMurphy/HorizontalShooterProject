using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float speed = 2;
    public int endPoint = -120;
    public int returnPoint = 128;

    void Update()
    {

        Vector2 move = new Vector2(speed * Time.deltaTime, 0);
        transform.Translate(move * -speed);

        if (transform.position.x <= endPoint)
        {
            Debug.Log("Loop");
            transform.position = new Vector2(returnPoint, 0);
        }
    }
}
