using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{   
    public GameObject destroyBox;
    public GameObject player;
    public GameObject enemy;
    public GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
        if(collision.gameObject.tag == "Player")
        {
            // destroy player
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Destroyer")
        {
            
            Destroy(gameObject);
        }

    }
}
