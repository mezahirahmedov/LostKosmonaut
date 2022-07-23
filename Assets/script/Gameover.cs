using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.CompareTag("Player"))
		{
			if (collision.relativeVelocity.y <= 0f)
			{
				SceneManager.LoadScene(4);
			}

		}


	}
}
