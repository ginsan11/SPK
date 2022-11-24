using UnityEngine;

public class SwordColliderDamage : MonoBehaviour
{
    //This script is attached to the sword the player is holding.
    //It has a box collider which acts as a trigger which damages the skeleton when it triggers with it.
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Ensure that we are playing the attack animation 
            if (FindObjectOfType<Player>().isPlayAttackAnimation)
            {
                Debug.Log("Attacked The Enemy With Sword!");
            
                //Call the Skeleton Script and make it take a damage of 20.
                FindObjectOfType<Skeletons>().TakeDamage(20);
            }
        }
    }
}
