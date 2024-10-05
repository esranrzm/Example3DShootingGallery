using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target")) //I hit the object tagged as target
        {
            GameController.score++;
            Destroy(other.gameObject); //destroy brick
            Destroy(gameObject); //destroy projectiler/bullet
        } 
    }
}
