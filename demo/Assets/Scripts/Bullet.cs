using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Pickup")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}
}
