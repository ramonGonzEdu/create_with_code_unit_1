using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public GameObject player;

	void Start()
	{

	}

	// Below line makes the following code smoother since it runs after the car is moved with physics
	// void LateUpdate()
	void Update()
	{
		transform.position = player.transform.position + new Vector3(0, 5, -7);

	}

}