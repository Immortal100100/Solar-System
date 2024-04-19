using UnityEngine;
using System.Collections;
using UnityEngine.XR.Interaction.Toolkit;
public class LookAtTarget : MonoBehaviour {

    public Transform destination;
    public Transform Player;
    public Transform Canvas;
    public Transform UI;
    public void Pan()
    {
        foreach (Transform t in Canvas) 
        {
            t.gameObject.SetActive(false);
        }
        Player.SetParent(destination.parent);
        Player.localPosition = destination.localPosition ;
        Camera camera = Camera.main;
        //Quaternion rotation = Quaternion.identity ;
        //rotation.eulerAngles = new Vector3(0,-90,0) ;
        //camera.transform.rotation = rotation;\
        Player.LookAt(destination.parent, Player.localPosition);
        Canvas.SetParent(destination.parent);
        UI.gameObject.SetActive(true);
    }
}
