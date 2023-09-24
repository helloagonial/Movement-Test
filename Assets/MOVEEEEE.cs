using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEEEEE : MonoBehaviour
{
    public Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            RB.AddRelativeForce(new Vector3(0, 0, 1f));
        }
        if (Input.GetKey("s"))
        {
            RB.AddRelativeForce(new Vector3(0, 0, -1f));
        }
        if (Input.GetKey("a"))
        {
            RB.AddRelativeForce(new Vector3(-1f, 0, 0));
        }
        if (Input.GetKey("d"))
        {
            RB.AddRelativeForce(new Vector3(1f, 0, 0));
        }
    }
}
