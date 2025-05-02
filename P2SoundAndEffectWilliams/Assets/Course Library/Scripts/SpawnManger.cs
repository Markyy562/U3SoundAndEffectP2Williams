using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject obstaclePerfab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
     
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstaclePerfab, spawnPos, obstaclePerfab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
