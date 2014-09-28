using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float Tumble;
	public int MaxSpeed;
	// Use this for initialization
	void Start () {
		float speed = Random.Range (1, MaxSpeed);
		rigidbody.velocity = -transform.forward * speed;
		rigidbody.angularVelocity = Random.insideUnitSphere * Tumble;
		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
