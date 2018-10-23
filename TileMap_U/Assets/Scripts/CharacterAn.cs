using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAn : MonoBehaviour {

    private Animator an;

    void Start () {
        an = GetComponent<Animator>();
	}
	
	
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)){
            an.SetBool("IsRunning", true);
        } else {
            an.SetBool("IsRunning", false);
        }

        if (Input.GetKey(KeyCode.UpArrow)){
            an.SetTrigger("Jump");
        }
	}
}
