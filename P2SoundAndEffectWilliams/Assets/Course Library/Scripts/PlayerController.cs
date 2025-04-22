using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerR6; 
    // Start is called before the first frame update
    void Start()
    {
        playerR6 = GetComponent<Rigidbody>();
        playerR6.AddForce(Vector3.up * 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
