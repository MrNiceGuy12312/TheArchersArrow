using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{         
    [SerializeField] private string newLevel;


    // Start is called before the first frame update
    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Target")
        {

            Destroy(col.gameObject);
            Score.scoreValue += 50;
            SceneManager.LoadScene(newLevel);
        }
        
        if (col.gameObject.tag == "Arrow")
        {

            Destroy(col.gameObject);

        }

        if (col.gameObject.tag == "Blockade")
        {
            Score.scoreValue += 20;
            Destroy(col.gameObject);

        }
    }
 }
