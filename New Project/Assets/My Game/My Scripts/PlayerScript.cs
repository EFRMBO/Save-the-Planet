using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public int coins;
	public Light dirlight;
	public Material daySky;
	public Material nightSky;
    public GameObject Bridge;
	public void Nightmode()
	{
		dirlight.intensity = 0.02f;
		RenderSettings.skybox = nightSky;
	}

    public void Daymode()
    {
        dirlight.intensity = 0.7f;
        RenderSettings.skybox = daySky;
    }



    // Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
    protected void Start() {
        
    }

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {
			coins++;
			HUD.UpdateCoinCount(coins);
			Destroy(collided.gameObject);
		}

        if (collided.gameObject.tag == "Coin2")
        {
            coins+=5;
            HUD.UpdateCoinCount(coins);
            Destroy(collided.gameObject);
        }


        if (collided.gameObject.name == "Powerup1") {
			Destroy(collided.gameObject);
            Abilities.doubleJumpEnabled = true;
            Bridge.SetActive(true);
		}

        if (collided.gameObject.name == "Powerup2")
        {
            Destroy(collided.gameObject);
            Abilities.spinAttackEnabled = true;

        }

    }


    private void Update()
    {
        if (coins == 8) 
        {
            Abilities.speedBoostEnabled = true;
        }
        
    }

}