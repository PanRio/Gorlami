using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public Camera camera;

    public LayerMask interactMask;
    GameObject holdingObj = null;

    bool isHolding = false;

    public float distanceToObj = 10f;
    public float holdingOffset = 2f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!isHolding)
            {
                Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.gameObject.layer == interactMask)
                    {
                        holdingObj = hit.transform.gameObject;
                        isHolding = true;
                    }

                    Debug.Log("HIT " + hit.transform.name);
                }
                else
                {
                    Debug.Log("NOT HIT");
                }
            }
            else
            {
                isHolding = false;
                holdingObj = null;
            }

        }

       

        
        Debug.Log(camera.transform.rotation.eulerAngles);
        Debug.Log(camera.transform.forward);

        if (isHolding)
        {
            holdingObj.transform.position = camera.transform.position + camera.transform.forward * holdingOffset;
            holdingObj.transform.rotation.SetEulerAngles(camera.transform.rotation.eulerAngles);
        }

    }
   
}
