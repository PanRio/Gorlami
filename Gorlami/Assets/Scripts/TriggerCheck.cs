using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    Material materialRed;
    public Material materialGreen;

    public Collider col;
    // Start is called before the first frame update
    void Start()
    {
        materialRed = GetComponent<Material>();
    }

    void OnCollisionEnter(Collision colider)
    {
        Debug.Log(colider.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
