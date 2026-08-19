using UnityEngine;

public class ObjectHit : MonoBehaviour
{
 
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has hit the object!");
        }
    }

}
