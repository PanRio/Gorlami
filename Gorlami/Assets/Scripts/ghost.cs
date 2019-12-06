using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour {

    public Transform player;
    public Transform ghostt;

    void Start() {

    }

    // Update is called once per frame
    void LateUpdate() {
       // float temp = player.GetComponent<moveToAnotherSide>().distanceBetweenScean;

        player.localPosition = new Vector3(player.localPosition.x,player.localPosition.y,player.localPosition.z - player.GetComponent<moveToAnotherSide>().distanceBetweenScean);
    }
}

