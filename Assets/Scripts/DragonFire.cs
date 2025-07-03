using UnityEngine;

public class DragonFire : MonoBehaviour
{
    public GameObject dragonFire;
    public float launchVelocity = 1200f;

    public void ShootFromMouth()
    {
        if (dragonFire != null)
        {
            GameObject fire = Instantiate(dragonFire, transform.position, transform.rotation);
            Rigidbody rb = fire.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * launchVelocity);
            }
        }
    }
}
