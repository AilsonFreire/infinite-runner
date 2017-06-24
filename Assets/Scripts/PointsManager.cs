using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour {

	public Text textPoints;
	int points;

	void Start () {
		textPoints.text = "POINTS: ";
		points = 0;
	}

	void Update () {
		textPoints.text = "POINTS: " + points;
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Cube(Clone)")
			points += 10;
	}
}
