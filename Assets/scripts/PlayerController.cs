using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
  horizontalInput = Input.GetAxis("Horizontal");

    transform.Translate(Vector3.forward * Time.deltaTime * speed);
    transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
  }
}
