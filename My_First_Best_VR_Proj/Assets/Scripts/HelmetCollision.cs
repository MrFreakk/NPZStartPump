using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetCollision : MonoBehaviour
{
    public bool collisionDetectHelmet = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "HeadCollider")
        {
            gameObject.SetActive(false);
            collisionDetectHelmet = true;
        }
    }

}
