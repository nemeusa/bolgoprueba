using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolita : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        launch();
    }

    void FixedUpdate()
    {
       rb.velocity = rb.velocity.normalized * speed;
    }

    void launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-2, 2);

        rb.velocity = new Vector3(x, y, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        Vector3 nextDirection = Vector3.Reflect(rb.velocity, normal);

        if(Mathf.Abs(nextDirection.y) < 0.1f)
        {
            nextDirection.y = Random.Range(-7, 7);
        }
        
        if(Mathf.Abs(nextDirection.x) < 0.1f)
        {
            nextDirection.x = Random.Range(-7, 7);
        }

        rb.velocity = nextDirection.normalized * speed;
    }
}
