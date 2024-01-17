using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vespaMovementSouth : MonoBehaviour
{

    public Rigidbody toyCarRigidBody;

    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        // toyCarRigidBody.AddForce(0,0,-1 * 10f);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // toyCarRigidBody.AddForce(0, 0, -1 * speed);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}




