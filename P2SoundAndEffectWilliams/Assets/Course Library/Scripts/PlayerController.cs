using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerR6;
    public float jumpForce = 10;
    public float gravityModifier;
    
    // Start is called before the first frame update
    void Start()
    {
        playerR6 = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerR6.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}