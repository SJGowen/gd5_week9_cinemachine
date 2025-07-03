using UnityEngine;

public class DragonFire : MonoBehaviour
{
    public GameObject dragonFireBreath;

    public void ShootFromMouth()
    {
        if (dragonFireBreath != null)
        {
            //Debug.Log("Dragon is breathing fire!");
            GameObject breath = Instantiate(dragonFireBreath, transform.position, transform.rotation);
            Destroy(breath, 3.0f);
        }
    }
}
