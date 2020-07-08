using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnCollisionEnter2D(Collision2D col)
        {
        

            if (col.gameObject.tag == "Target")
             {
                Debug.Log("oi");
                Destroy(col.gameObject);

            }

            if (col.gameObject.tag == "Blockade")
            {
                Debug.Log("oiiii");
                Destroy(col.gameObject);

            }
        }
}
