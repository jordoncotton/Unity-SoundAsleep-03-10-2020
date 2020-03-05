using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundRingBehaviour : MonoBehaviour
{

    public AudioSource SoundSorc;

    public GameObject SoundRing;

    public GameObject AttachmentObj;

    public int Echo;
    //number by which we will multiply the volume to get the size of the sound ring

    Vector3 RingSize;

    Vector3 RingPosition;

    void hold()
    {

    }

    void Start()
    {


    }

    void Update()
    {

        SoundRing.transform.localScale = RingSize;

        SoundRing.transform.position = RingPosition;

        RingSize = new Vector3(Echo  * SoundSorc.volume, 0.1f, Echo *  SoundSorc.volume);


        RingPosition = AttachmentObj.transform.position;


        if (SoundSorc.enabled)
        {
            SoundRing.SetActive(true);

        }

        else
        {
            SoundRing.SetActive(false);
        }

    }
}
