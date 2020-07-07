using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingArrow : MonoBehaviour
{

    public float speed;


    public GameObject Arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject ArrownIns = Instantiate(Arrow, transform.position, transform.rotation);
        //add the speed the arrow shoots at


        ArrownIns.GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
    }
}
