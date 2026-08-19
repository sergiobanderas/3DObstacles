using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] private float dropInterval = 2f;

    MeshRenderer meshRenderer;
    Rigidbody rb;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>(); 

        meshRenderer.enabled = false;
        rb.useGravity = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropInterval)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;  
        }
    }
}
