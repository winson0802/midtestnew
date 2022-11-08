using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    private float hp = 100f;
public GameObject enemy;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
    
    if (other.gameObject.name == "player")
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Bullet")
        {
            
            Bullet bullet = other.GetComponent<Bullet>();

           
            hp -= bullet.atk;

          
            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }

    }

   

}

