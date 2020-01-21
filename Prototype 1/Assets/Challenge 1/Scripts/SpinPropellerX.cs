using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float verticalInput;
    public float turnSpeed = 10.0f;
    public float target = player.transform.position;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.RotateAround(target, Vector3.up, verticalInput * turnSpeed * Time.deltaTime);
    }
}
