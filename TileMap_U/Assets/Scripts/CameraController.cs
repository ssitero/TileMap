using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

    public GameObject player;      
    private Vector3 offset;         


    void Start () 
    {

        player.position.x
    }
    

    void LateUpdate () 
    {

        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
