using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    /// <summary>
    /// Projectile's speed.
    /// </summary>
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile forward along the z axis.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
