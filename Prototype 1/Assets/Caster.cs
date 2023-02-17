using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caster : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)){
            Ray theRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHitInfo;

            if (Physics.Raycast(theRay, out rayHitInfo)) {
                
                if (rayHitInfo.collider.gameObject.CompareTag("pop")) {
                    Debug.Log(rayHitInfo.collider.gameObject);
                    GameObject.Destroy(rayHitInfo.collider.gameObject);
                    
                } else
                {
                  //  GameObject.Instantiate(prefab, rayHitInfo.point, Quaternion.identity);

                }
            }
        }
    }
}
