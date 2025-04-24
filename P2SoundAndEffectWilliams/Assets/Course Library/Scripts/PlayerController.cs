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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerR6.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}