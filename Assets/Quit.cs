using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    public void End()
    {
       Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
