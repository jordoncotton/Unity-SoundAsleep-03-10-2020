using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehaviour : MonoBehaviour
{

    public GameObject Mcgufffin1;

    public GameObject Mcgufffin2;

    public GameObject Mcgufffin3;

    public GameObject Mcgufffin4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Mcgufffin1.active == false&&Mcgufffin2==false&&Mcgufffin3==false&&Mcgufffin4==false)
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
