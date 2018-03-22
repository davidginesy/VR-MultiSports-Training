using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseball : MonoBehaviour {

    public AudioSource src;
    public TrailRenderer t;

    private Rigidbody rb;
    private float velocityMax = 200f;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Random.Range(6f, 8f), ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bat"))
        {
            rb.velocity = Vector3.zero;
			Debug.Log ("Play sound");
            src.Play();
            Physics.IgnoreCollision(collision.gameObject.GetComponent<CapsuleCollider>(), gameObject.GetComponent<SphereCollider>());

            float forceMultiplier = GetBatForce(collision.gameObject.GetComponent<Rigidbody>());
            Vector3 direction = (transform.position - collision.contacts[0].point).normalized;
            rb.AddForce(direction * forceMultiplier, ForceMode.Impulse);
            rb.useGravity = true;

            t.enabled = true;
            Destroy(gameObject, 2f);
        }
    }

    private float GetBatForce(Rigidbody batRB)
    {
        return batRB.velocity.magnitude / velocityMax * 50f;
    }
}
