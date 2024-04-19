using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    public void restart()
    {
        //foreach (GameObject child in Canvas.transform)
        //{
        //    child.gameObject.SetActive(false);
        //}
        SceneManager.LoadScene(0);
    }
}
