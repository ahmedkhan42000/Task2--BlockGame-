using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    // Start is called before the first frame update
    private int LowBound = 25;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > LowBound)
        {
            Destroy(gameObject);
        } 
    }
}
