using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
	public Transform[] shotGunMuzzle; //���� ���� źȯ ������ 
	public Projectile projectile;

	public float msBetweenShots = 100;
	public float muzzleVelocity = 50; //���ź ���ٴ� ������

	float nextShotTime;
	public void SgShot()
	{
		if (Time.time > nextShotTime)
		{
			for (int i = 0; i < shotGunMuzzle.Length; i++)
			{
				nextShotTime = Time.time + msBetweenShots / 1000;
				Projectile newProjectile = Instantiate(projectile, shotGunMuzzle[i].position, shotGunMuzzle[i].rotation) as Projectile;
				newProjectile.SetSpeed(muzzleVelocity);
			}
		}
	}

}