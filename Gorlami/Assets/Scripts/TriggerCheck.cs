using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    public Material materialRed;
    public GameObject Dorki;
    public Material materialGreen;

   

    public Collider col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider colider)
    {
       

        

        Dorki.GetComponent<Animator>().SetBool("DorState", true);
        gameObject.GetComponent<MeshRenderer>().material = materialGreen;
        
    }

    void OnTriggerExit(Collider col)
    {
        Dorki.GetComponent<Animator>().SetBool("DorState", false);
        gameObject.GetComponent<MeshRenderer>().material = materialRed;
    }




        // Update is called once per frame
    void Update()
    {
        
    }
}
