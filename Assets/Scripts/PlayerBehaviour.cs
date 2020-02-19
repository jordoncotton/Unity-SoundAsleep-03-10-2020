using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
   

    public int EndValue;

    // Use this for initialization
    void Start ()
    {
        EndValue = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(EndValue >= 4)
        {
            SceneManager.LoadScene(2);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Guffy"))
        {
          //  if (Input.GetKeyDown(KeyCode.E))
            //{
                EndValue++;
                other.gameObject.SetActive(false);

            //}
        }
    }
}
