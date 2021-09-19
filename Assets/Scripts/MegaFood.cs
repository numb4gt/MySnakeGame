using UnityEngine;
using System.Collections;

public class MegaFood : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("SnakeMain"))
		{
			other.GetComponent<SnakeMovment>().AddMegaTail();
			Destroy(gameObject);
		}
	}

}
