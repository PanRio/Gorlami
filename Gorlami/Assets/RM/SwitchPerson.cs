using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPerson : MonoBehaviour {

    public bool isDarkState = false;//1-ciemny . 0-jasny
    public Transform camera;
    public float distanceBetweenScean = 55f;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.E)) {
            //moveToAnotherSide(camera,distanceBetweenScean,isDarkState);/*
            if(isDarkState) {
                isDarkState = false;
                camera.transform.localPosition = new Vector3(camera.transform.localPosition.x,camera.transform.localPosition.y,camera.transform.localPosition.z - distanceBetweenScean); //SetParent localScale.Set(0,4,0);
            }

            else {
                isDarkState = true;
                camera.transform.localPosition = new Vector3(camera.transform.localPosition.x,camera.transform.localPosition.y,camera.transform.localPosition.z + distanceBetweenScean); //SetParent localScale.Set(0,4,0);
            }
            
        }
    }

    static bool moveToAnotherSide(Transform t,float distanceBetweenScean,bool isDarkState) {
        if(isDarkState) {
            isDarkState = false;
            t.transform.localPosition = new Vector3(t.transform.localPosition.x,t.transform.localPosition.y,t.transform.localPosition.z - distanceBetweenScean); //SetParent localScale.Set(0,4,0);
        }

        else {
            isDarkState = true;
            t.transform.localPosition = new Vector3(t.transform.localPosition.x,t.transform.localPosition.y,t.transform.localPosition.z + distanceBetweenScean); //SetParent localScale.Set(0,4,0);
        }

        return true;
    }
}
