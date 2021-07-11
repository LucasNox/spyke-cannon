using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	private float turnSpeed;
	[SerializeField]
	private float repulsionFraction;
	[SerializeField]
	private GameObject bulletPrefab;
	[SerializeField]
	private float fireRate;
	private Rigidbody2D rb;
	private bool canShoot = true;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && canShoot)
		{
			StartCoroutine("Shoot");
		}
	}

	private void FixedUpdate()
	{
		rb.AddTorque(Input.GetAxisRaw("Horizontal") * turnSpeed * -1 * Time.fixedDeltaTime);
	}

	private IEnumerator Shoot()
	{
		canShoot = false;
		Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation).GetComponent<Bullet>();
		bullet.Propel(transform.up);
		rb.AddForce(transform.up * bullet.Speed * repulsionFraction * -1);
		yield return new WaitForSeconds(fireRate);
		canShoot = true;
	}
}
