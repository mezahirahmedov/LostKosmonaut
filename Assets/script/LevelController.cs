using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject platformPreFab;
    public GameObject AstroidPreFab;

    [SerializeField] int PlatformNumber1 = 100;
    [SerializeField] int AstroidNumber1 = 5;

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

        Vector2 astroidvector1 = new Vector2();
        for (int i = 0; i < AstroidNumber1; i++)
        {
            GameObject tempPlatform = Instantiate(AstroidPreFab);
            astroidvector1.x = Random.Range(-2f, 2f);
            astroidvector1.y += Random.Range(20, 50);
            tempPlatform.transform.position = astroidvector1;

        }

    }
}
