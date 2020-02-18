using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoBehaviousBehaviour : MonoBehaviour
{

    public GameObject Timaeus;

    public GameObject Critias;
    // Start is called before the first frame update
    void Start()
    {
        Timaeus.GetComponent<AudioSource>().enabled = false;

        Critias.GetComponent<AudioSource>().enabled = false;
    }

    // Update is called once per frame 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            Timaeus.GetComponent<AudioSource>().enabled = true; 
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            Critias.GetComponent<AudioSource>().enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            Timaeus.GetComponent<AudioSource>().enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            Critias.GetComponent<AudioSource>().enabled = false;
        }


    }
}
