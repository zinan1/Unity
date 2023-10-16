using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 1f; 

    // Update is called once per frame
    void Update()
    {
        
        Vector3 currentPosition = transform.position;

        
        float newY = Mathf.Sin(Time.time)* 1/3 * speed; 
        Vector3 newPosition = new Vector3(currentPosition.x, newY, currentPosition.z);

        
        transform.position = newPosition;
    }

}
