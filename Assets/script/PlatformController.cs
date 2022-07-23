using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
	{
	
		if(collision.gameObject.CompareTag("Player"))
		{
			if (collision.relativeVelocity.y <= 0f)
			{
				collision.gameObject.GetComponent<PlayerController>().playerjump();
				

			}
			
		}

		
	}
}
