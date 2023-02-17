using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject hardenedSphere;
    public int nbLives = 4;
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
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            nbLives--;
            thePlayer.transform.position = new Vector3(0.0f, 70.0f, 0.0f);
            if (nbLives < 0) {
                thePlayer.transform.position = new Vector3(0.0f, 1000.0f, 0.0f);
                hardenedSphere.GetComponent<SphereCollider>().enabled = true;
            }
        }

    }
}
