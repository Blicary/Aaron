﻿class Boundary
{
    var xMin : float;
    var xMax : float;
    var zMin : float;
    var zMax : float;
}

var speed : float;
var tilt : float;
var boundary : Boundary;

var shot : GameObject;
var shotSpawn : Transform;
var fireRate : float;

private var nextFire : float;

function Update () {
    if (Input.GetButton("Jump") && Time.time > nextFire)
    {
        nextFire = Time.time + fireRate;
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audio.Play ();
    }
}

function FixedUpdate () {
     var moveHorizontal : float= Input.GetAxis ("Horizontal");
     var moveVertical : float= Input.GetAxis ("Vertical");

     var movement : Vector3= new Vector3 (moveHorizontal, 0.0f, moveVertical);
    rigidbody.velocity = movement * speed;

    rigidbody.position = new Vector3 
    (
        Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
        0.0f, 
        Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
    );

    rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
}