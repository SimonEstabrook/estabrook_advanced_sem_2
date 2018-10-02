using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollManager : MonoBehaviour
{
    public GameObject GroundObject;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Mouse ScrollWheel");
        
    }
}
