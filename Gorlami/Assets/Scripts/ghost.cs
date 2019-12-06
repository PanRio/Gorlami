using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour {

    public Transform player;
    public Transform ghostt;

    void Start() {

    }

    // Update is called once per frame
    void Update() {
       // float temp = player.GetComponent<moveToAnotherSide>().distanceBetweenScean;
        float a =player.transform.localPosition.x;
        float b =ghostt.transform.localPosition.x;
        //ghostt.transform.localPosition = new Vector3(player.transform.localPosition.x,player.transform.localPosition.y,player.transform.localPosition.z + 11); //SetParent localScale.Set(0,4,0);    
    }
}

