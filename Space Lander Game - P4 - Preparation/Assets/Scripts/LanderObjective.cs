using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class LanderObjective : MonoBehaviour
{
    private bool canRetractLandingPad;

    private bool contactMade;

    private Lander playerLander;

    void Start()
    {
        playerLander = GameObject.Find("Lander").GetComponent<Lander>();
        if (playerLander == null)
        {
            Debug.LogError("Cannot find Lander gameobject. Make sure your Lander is named Lander.");
        }
    }

    public void ActivateLandingPad(Vector2 impact)
    {
        if (impact.magnitude < 3)
        {
            Debug.Log("Activated landing pad");

            if (canRetractLandingPad == false && contactMade == false)
            {
                StartCoroutine(RectractLandingPad());
            }
        }
    }

    private IEnumerator RectractLandingPad()
    {
        canRetractLandingPad = true;
        contactMade = true;
        yield return new WaitForSeconds(0.5f);
        canRetractLandingPad = false;
        
        // May have crash landed
        if (playerLander != null)
        {
            playerLander.allowThrust = false;
            playerLander.DetectLanding();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (canRetractLandingPad)
        {
            var landingPadPositionY = transform.position.y - Time.deltaTime / 3;
            transform.position = new Vector2(transform.position.x, landingPadPositionY);
        }
    }
}