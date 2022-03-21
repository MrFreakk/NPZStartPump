using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int doorOpenScore;

    public HelmetCollision collisionHelmet;
    public GlassCollision collisionGlass;
    public Maskcollision collisionMask;
    public Gassmaskcollision collisionGassmask;

    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        doorOpenScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionHelmet.collisionDetectHelmet)
        {
            doorOpenScore += 1;
            collisionHelmet.collisionDetectHelmet = false;
        }

        if (collisionGlass.collisionDetectGlass)
        {
            doorOpenScore += 1;
            collisionGlass.collisionDetectGlass = false;
        }

        if (collisionMask.collisionDetectMask)
        {
            doorOpenScore += 1;
            collisionMask.collisionDetectMask = false;
        }
       
        if (collisionGassmask.collisionDetectGasmask)
        {
            doorOpenScore += 1;
            collisionGassmask.collisionDetectGasmask = false;
        }
       
        if (doorOpenScore == 4)
        {
            DoorOpen();
        }
        
    }

    private void DoorOpen()
    {
        Door.transform.rotation = Quaternion.Euler(0, -120, 0);
    }
}
