using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAssigner : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] Planets;
    void Awake()
    {
        Planets = GameObject.FindGameObjectsWithTag("Celestial");
        foreach(var planet  in Planets)
        {
            planet.AddComponent<ChangeLookAtTarget>();
        }
    }

}
