using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;
    public GameObject degats;
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemies myEnemy = collision.gameObject.GetComponent<Enemies>();
        if(myEnemy)
        {
            myEnemy.ReduceHP();
        }
       
        Destroy(gameObject);
        //Instantiate(degats, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
    }


}
