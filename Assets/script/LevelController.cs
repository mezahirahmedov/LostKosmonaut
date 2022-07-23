using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject platformPreFab;

    [SerializeField] int PlatformNumber1 = 100;


    void Start()
    {
        LevelMake();
    }

    void LevelMake()
    {
        Vector2 platformvector1 = new Vector2();
        for (int i = 0; i < PlatformNumber1; i++)
        {
            GameObject tempPlatform = Instantiate(platformPreFab);
            platformvector1.x = Random.Range(-2f,2f);
            platformvector1.y += Random.Range(1.5f,2);
            tempPlatform.transform.position = platformvector1;
           
        }

    }
}
