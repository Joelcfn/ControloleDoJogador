using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    public float verticalInput;

    private Rigidbody rb;

    void Start()
    {
        // Obtém o componente Rigidbody ligado ao avião
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Obtém a entrada do jogador (setas ou W/S)
        verticalInput = Input.GetAxis("Vertical");

        // Movimento para frente baseado na rotação atual
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

        // Só rotaciona se pressionar tecla para cima/baixo
        if (Mathf.Abs(verticalInput) > 0.01f)
        {
            Quaternion deltaRotation = Quaternion.Euler(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }
}
