using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject filete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision");
        if (collision.gameObject == filete) Debug.Log("Estaba rico el filete");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colision con" + other.name);
    }
}
