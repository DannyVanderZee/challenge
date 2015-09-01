using UnityEngine;
using System.Collections;

public class rollen : MonoBehaviour {
	public float speed;

	

	

	void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		
		Vector3 pos = new Vector3(x, 0f, z);
		GetComponent<Rigidbody>().AddForce (pos * speed);

	}

		}
	

