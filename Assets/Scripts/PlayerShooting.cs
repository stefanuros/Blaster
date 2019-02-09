using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject defaultBullet;
    [HideInInspector]public GameObject Bullet;
    public float defaultBulletSpeed;
    [HideInInspector]public float bulletSpeed;
    public float defaultReloadSpeed;
    [HideInInspector]public float reloadSpeed;
	
    void Start()
    {
        reloadSpeed = defaultReloadSpeed;
        bulletSpeed = defaultBulletSpeed;
        Bullet = defaultBullet;
    }

	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown("z"))
        {
            createBullet();
        }
	}

    //A function for creating the bullet
    void createBullet()
    {
        GameObject instance;

        //Creating a bullet
        instance = Instantiate(Bullet, transform.position, transform.rotation);
        //Getting the rigidbody of the bullet
        Rigidbody2D instanceRB = instance.GetComponent<Rigidbody2D>();

        //Getting the ships velocity
        Vector3 shipVel = transform.parent.GetComponent<PlayerMovement>().GetComponent<Rigidbody2D>().velocity;
        //Transfering the velocity vector into a scalar multiple
        float shipVelMag = shipVel.magnitude * 50;

        //Applying the ships velocity along with the desired bullet velocity as a force to the bullet
        instanceRB.AddForce(transform.up * (bulletSpeed + shipVelMag));
    }
}
