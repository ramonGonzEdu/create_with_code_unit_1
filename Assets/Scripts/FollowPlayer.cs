using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public GameObject player;
	public Vector3 offset = new Vector3(0, 5, -7);

	void Start()
	{

	}

	// Below line makes the following code smoother since it runs after the car is moved with physics
	// void LateUpdate()
	void OnPreRender()
	// void Update()
	{
		transform.position = player.transform.position + offset;

	}

}