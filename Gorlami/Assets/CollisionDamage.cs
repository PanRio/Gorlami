using UnityEngine;

public class CollisionDamage : MonoBehaviour
{

    [SerializeField] private Transform respawn;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "enemy")
        {
            transform.position = respawn.transform.position;
        }
   }
}
