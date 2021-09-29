using UnityEngine;

public class LanderFeet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("LanderObjective"))
        {
            var landerObjective = hitInfo.gameObject.GetComponent<LanderObjective>();

            if (landerObjective != null)
            {
                landerObjective.ActivateLandingPad(hitInfo.relativeVelocity);
            }
        }
    }
}