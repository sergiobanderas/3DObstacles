using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] private Vector3 rotationSpeed = new Vector3(0f, 100f, 0f);
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
