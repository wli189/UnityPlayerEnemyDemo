using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -6);
        }

        if (transform.position.z > 6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 6);
        }

        if (transform.position.x < -11.25)
        {
            transform.position = new Vector3(-11.25f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 11.25)
        {
            transform.position = new Vector3(11.25f, transform.position.y, transform.position.z);
        }
    }
}
