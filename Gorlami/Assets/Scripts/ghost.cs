using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{

    public Transform player;
    public Transform ghostt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ghostt.transform.localPosition = new Vector3(player.transform.localPosition.x,player.transform.localPosition.y,player.transform.localPosition.z+player.GetComponent<moveToAnotherSide>().distanceBetweenScean); //SetParent localScale.Set(0,4,0);    
    }
}

