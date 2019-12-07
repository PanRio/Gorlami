using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "enemy")
        {
            Debug.Log("uderzyłęs");
            Destroy(gameObject);
            // a rigidbody tagged as "Ball" hit the player
        }
    }
}
