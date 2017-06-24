using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	public float Speed = 30f;
	protected Vector3 movement;

	void Update ()
	{
		movement = Vector3.left * (Speed / 10) * Speed * Time.fixedDeltaTime;
		transform.Translate(movement,Space.World);	
	}
}
