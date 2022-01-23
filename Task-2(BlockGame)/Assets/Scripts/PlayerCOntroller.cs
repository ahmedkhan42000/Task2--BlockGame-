using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    public float HorizontalInput;
    private float Speed = 50;
    private float xBoundry = 80;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.x < -xBoundry)
        {
            transform.position = new Vector3(-xBoundry, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBoundry)
        {
            transform.position = new Vector3(xBoundry, transform.position.y, transform.position.z);
        }
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Speed * Time.deltaTime);

    }
}
