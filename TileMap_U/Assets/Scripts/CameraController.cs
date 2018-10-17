using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

    public Transform player;      
    private Vector3 offset;         


    void Start () 
    {

        //transform.position = new Vector3(14.88f, -2.4f, 0.0f);
        offset = transform.position - player.transform.position;
        transform.position = player.transform.position + offset;
    }
    

    void LateUpdate () 
    {

        this.gameObject.transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
