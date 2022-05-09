using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

/*Base class for colleting bullets
 * Attached to the player
 */
public class BulletPickupComponent : PickUpComponent
{
    PlayerController playerController;


    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    public override void pickupTrigger(PickUpScript pickup)
    {
        if (pickup != null)
        {
            if (pickup.pickupType == PickUpScript.PickUpType.Bullet
                && playerController.max_bullets - playerController.bullets > 0)
            {
                playerController.IncrementBullets(pickup.amount);
                pickup.destroyThisObject();
            }
        }
    }
}