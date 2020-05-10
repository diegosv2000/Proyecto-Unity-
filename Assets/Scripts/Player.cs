using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private new Rigidbody rigidbody;
    public float speed = 5f;
    public float jump = 120f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        float jum = Input.GetAxisRaw("Jump");
        if (hor != 0.0f || ver != 0.0f || jum != 0.0f)
        {
            Vector3 dir = transform.forward * ver + transform.right * hor + transform.up * jum * jump * Time.deltaTime;
            rigidbody.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            rigidbody.AddForce(0,3,-3, ForceMode.Impulse);
        }
    }
}
