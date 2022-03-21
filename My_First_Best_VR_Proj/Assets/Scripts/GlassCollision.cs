using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassCollision : MonoBehaviour
{
    public bool collisionDetectGlass = false;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "HeadCollider")
        {
            gameObject.SetActive(false);
            collisionDetectGlass = true;
        }

           
    }
}
