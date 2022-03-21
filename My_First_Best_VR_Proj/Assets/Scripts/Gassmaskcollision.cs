using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gassmaskcollision : MonoBehaviour
{

    public bool collisionDetectGasmask = false;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "HeadCollider")
        {
            gameObject.SetActive(false);
            collisionDetectGasmask = true;
        }



    }
}