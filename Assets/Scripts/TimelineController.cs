using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public PlayableDirector playableDirector2;
   // public PlayableDirector playableDirectorID;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Megan") 
        {
            Play();
        }
        else if (other.gameObject.tag == "Sophie")
        {
            Play2();
        }
        //else if (other.gameObject.tag == "MyID")
        //{
         //   Debug.Log("I see my ID");

          //  IDPlay();
       // }
    }
    
    // Update is called once per frame
    void Play()
    {
        //foreach (PlayableDirector
           // playableDirector in playableDirector)
       // {
           
       // }
        playableDirector.Play();

    }
    void Play2()
    {
        
        playableDirector2.Play();

    }
    //void IDPlay()
    //{

       // playableDirectorID.Play();

    //}
}
