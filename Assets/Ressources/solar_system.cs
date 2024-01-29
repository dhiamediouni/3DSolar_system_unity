using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solar_sysem : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0f, rotationSpeed * Time.deltaTime, 0f);

    }
}