using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField] GameObject[] projectiles;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Entered Trigger");

            foreach (GameObject projectile in projectiles)
            {
                Debug.Log("Activating Projectile: " + projectile.name);
                projectile.SetActive(true);
            }
        }
    }
}
