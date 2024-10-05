using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody projectile;

    // Update is called once per frame
    void Update()
    {
        //projectile creation and launch
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation); //transform is referring to the player
            clone.velocity = transform.TransformDirection(Vector3.forward * 100); //velocity will be in the direction of forward
            Destroy(clone.gameObject, 1.5f); // I want to destroy the game object after 1.5 seconds
        }


        //player movement left and right
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f; //determines how can I can move the guy
        transform.Translate(x, 0, 0);
        
    }
}
