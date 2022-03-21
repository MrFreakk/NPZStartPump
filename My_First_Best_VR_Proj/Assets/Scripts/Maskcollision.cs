using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maskcollision : MonoBehaviour
{
    public bool collisionDetectMask = false;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "HeadCollider")
        {
            gameObject.SetActive(false);
            collisionDetectMask = true;
        }


            
    }
}
