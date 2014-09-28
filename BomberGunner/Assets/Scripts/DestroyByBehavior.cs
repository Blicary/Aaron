using UnityEngine;
using System.Collections;

public class DestroyByBehavior : MonoBehaviour
{
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}
