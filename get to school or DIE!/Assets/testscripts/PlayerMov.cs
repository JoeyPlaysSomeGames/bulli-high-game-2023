using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.AddForce(new Vector3(0,5,0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
