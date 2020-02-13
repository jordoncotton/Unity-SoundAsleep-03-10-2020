using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerChangeShader : MonoBehaviour
{
    public Shader baseShader;
    public Shader fadeShader;

	void OntriggerEnter(Collider other)
    {
        Debug.Log("Player has entered the trigger");

        if(other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.shader = fadeShader;
        }
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player has exited the trigger");

        if (other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.shader = baseShader;
        }
    }
}
