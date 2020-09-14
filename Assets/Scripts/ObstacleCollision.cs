using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cpu1;
    public GameObject Cpu2;
    public GameObject Cpu3;
    public GameObject Cpu4;
    public GameObject Cpu5;
    public GameObject Cpu6;
    public GameObject Cpu7;
    public GameObject Cpu8;
    public GameObject Cpu9;
    public GameObject Cpu10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.transform.position = new Vector3(0.006542306f, -0.4398407f, 2.299699f);
        }
        else if(other.tag == "Cpu1")
        {
            Cpu1.transform.position = new Vector3(-1.362604f, -0.4398407f, 0.6929628f);
        }
        else if (other.tag == "Cpu2")
        {
            Cpu2.transform.position = new Vector3(-1.538847f, -0.4398407f, 2.887001f);
        }
        else if (other.tag == "Cpu3")
        {
            Cpu3.transform.position = new Vector3(2.661153f, -0.4398407f, 1.507001f);
        }
        else if (other.tag == "Cpu4")
        {
            Cpu4.transform.position = new Vector3(2.461153f, -0.4398407f, -0.282999f);
        }
        else if (other.tag == "Cpu5")
        {
            Cpu5.transform.position = new Vector3(0.3311528f, -0.4398407f, -0.6929998f);
        }
        else if (other.tag == "Cpu6")
        {
            Cpu6.transform.position = new Vector3(4.941153f, -0.4398407f, -2.807001f);
        }
        else if (other.tag == "Cpu7")
        {
            Cpu7.transform.position = new Vector3(4.511153f, -0.4398407f, 0.09700012f);
        }
        else if (other.tag == "Cpu8")
        {
            Cpu8.transform.position = new Vector3(4.871153f, -0.4398407f, -2.252999f);
        }
        else if (other.tag == "Cpu9")
        {
            Cpu9.transform.position = new Vector3(2.981153f, -0.4398407f, -2.323f);
        }
        else if (other.tag == "Cpu10")
        {
            Cpu10.transform.position = new Vector3(0.7911528f, -0.4398407f, -2.502999f);
        }

    }
}
