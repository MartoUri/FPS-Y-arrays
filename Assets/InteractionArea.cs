using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    public Text text;
    public GameObject filete;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colision con " + other.name);
        score += (other.gameObject.GetComponent<PickUpScript>().valor);
        text.text = score.ToString();
        if (other.gameObject.GetComponent<PickUpScript>().esalimento)
        {
            Destroy(other.gameObject);
        }
    }
}
