using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

    public GameObject player;      
    private Vector3 offset;         


    void Start () 
    {

        transform.position = new Vector3(14.88f, -2.4f, 0.0f);
    }
    

    void LateUpdate () 
    {

        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
