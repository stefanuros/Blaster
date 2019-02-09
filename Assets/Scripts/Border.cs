using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Prevent the player from leaving the area
        if(other.tag == "Player")
        {
            //Moving the player to the center of the screen
            //In future, this will be game over
            other.transform.position = new Vector3(0, 0, other.transform.position.z);
        }
        //Remove any stray bullets
        else if(other.tag == "Bullet")
        {
            //When other bullets exist, dont destroy here
            //Instead, call a hitBorder() function that will exist in each bullet
            Destroy(other.gameObject);
        }
    }
}
