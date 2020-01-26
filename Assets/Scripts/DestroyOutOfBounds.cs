using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30.0f;
    private float lowerBoundary = -10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundary) // If the object passes the Top Boundary limit...
        {
            Destroy(gameObject); // Destory it.
        }
        else if (transform.position.z < lowerBoundary) // If the object passes the Lower Boundary limit...
        {
            Debug.Log("Game Over");
            Destroy(gameObject); // Destory it.
        }
    }
}
