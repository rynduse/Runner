using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.gameObject.GetComponent<PlayerMovement>().finished = true;
            Player.gameObject.GetComponent<Animator>().SetBool("isRunning", false);
        }

    }
}
