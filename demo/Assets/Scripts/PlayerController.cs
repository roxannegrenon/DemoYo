using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	GameObject bulletPrefab;

	[SerializeField]
	Transform bulletSpawn;

	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		transform.Rotate(0, h * Time.deltaTime * 150.0f, 0);
		transform.Translate(v * Time.deltaTime * 3.0f, 0, 0);

		if(Input.GetKeyDown(KeyCode.Space)) 
		{
			Fire();
		}
	}

	void Fire()
	{
		var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
		Destroy(bullet, 2.0f);
	}
}
