using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalyerController : MonoBehaviour
{
    private new Rigidbody rigidbody;
    private float distanceToGround;

    public bool Ongroud;
    //public float movementSpeed;
    public float jumpSpeed;
    public float velocidadMovimiento = 20f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        distanceToGround = GetComponent<Collider>().bounds.extents.y;
    }

    private bool IsGrounded()
    {
        return Physics.BoxCast(transform.position, new Vector3(0.4f, 0f, 0.4f), Vector3.down, Quaternion.identity, distanceToGround + 0.1f);
    }

    void Update()
    {

        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 movimiento = new
        Vector3(hor, 0f, ver);

        if (movimiento.magnitude > 1f)
        {
            movimiento.Normalize();
        }

        transform.position += movimiento * velocidadMovimiento * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && IsGrounded())    
        {
            rigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            Debug.Log("Salto");
        }

    }
}
