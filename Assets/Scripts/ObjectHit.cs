using UnityEngine;

public class ObjectHit : MonoBehaviour
{
 
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

}
