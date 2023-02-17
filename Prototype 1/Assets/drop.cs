using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    
    public bool dropped;
    public bool onPlatform;
    public int counter = 400;
    public int status = 0; //0->1->2 (green yellow red)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
    }
    
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            counter--;
            onPlatform = true;
            if (status == 0 && counter <660) {
                status = 1;
                //GetComponent<Material>().color = Color.yellow;
                Debug.Log(status);
            }

            if (status == 1 && counter < 330)
            {
                //GetComponent<Material>().color = Color.red;
                status = 2;
                Debug.Log(status);
            }

            if (counter <= 0) {
                GameObject.Destroy(GetComponent("Collider").gameObject);

            }



        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            onPlatform = false;
        }
    }
        
}


