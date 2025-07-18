using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float speed = 20.0f;
private float turnSpeed = 45.0f;
private float horizontalInput;
private float forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");

    // Moves the car forward based on vertical input
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

    // Rotates the car based on horizontal input
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
  }
}
