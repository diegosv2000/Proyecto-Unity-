using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_False : MonoBehaviour
{
    bool player_ground;
    public Rigidbody rbd;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator stop()
    {
        yield return new WaitForSeconds(2);
        rbd.isKinematic = false;
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player_ground = true;
            StartCoroutine(stop());
        }
    }
}
