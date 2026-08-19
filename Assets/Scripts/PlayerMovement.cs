using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Rigidbody rb;
    private float xInput;
    private float zInput;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(xInput, 0f, zInput);

        rb.MovePosition(
            rb.position + movement * speed * Time.fixedDeltaTime
        );
    }
}
