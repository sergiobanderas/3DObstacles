using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    void Start()
    {
        
    }
    
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;


        transform.Translate(xValue, yValue, zValue);        
    }
}
