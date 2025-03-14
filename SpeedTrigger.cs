using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f; 

    void OnTriggerEnter(Collider other)
    {
        //Incrementamos la velocidad del jugador
         other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    void OnTriggerExit(Collider other)
    {
        //Reduce la velocidad del jugador
         other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;

    }




}
