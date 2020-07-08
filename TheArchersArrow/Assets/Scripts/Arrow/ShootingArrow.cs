using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingArrow : MonoBehaviour
{

    public int maxAmmo = 3;
    public int currentAmmo = -1;

    public float speed;


    public GameObject Arrow;
    // Start is called before the first frame update
    void Start()
    {
           if (currentAmmo == -1)
        {
            currentAmmo = maxAmmo;
        }
    }

    // Update is called once per frame
    void Update()
    {
      if(currentAmmo <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        currentAmmo--;
        GameObject ArrownIns = Instantiate(Arrow, transform.position, transform.rotation);
        //add the speed the arrow shoots at


        ArrownIns.GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
    }
}
