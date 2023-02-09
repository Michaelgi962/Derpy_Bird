using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudFloat : MonoBehaviour
{
    public float speed = 10f;
    public float destroyX = -20f;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}