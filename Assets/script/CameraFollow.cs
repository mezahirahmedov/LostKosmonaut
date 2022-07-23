using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate() 
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime);
        gameObject.transform.position = new Vector3(0, transform.position.y, -10);
    }
}
