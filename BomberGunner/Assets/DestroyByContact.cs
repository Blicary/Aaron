using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{	

	public int hits;
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		hits++;
		
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
