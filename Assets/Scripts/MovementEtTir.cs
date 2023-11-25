using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.XR;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;

    public int multiShot;

    public float speed = 0.2f;

    AudioSource sfxTir;

    // Start is called before the first frame update
    void Start()
    {
        sfxTir = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // tir

            sfxTir.Play();
            Instantiate(bullet, parent.position, parent.rotation);


        }

        if(transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }
    /*public void lvl1_shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sfxTir.Play();
            Instantiate(bullet, parent.position, parent.rotation);
        }
    }
    public void lvl2_shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sfxTir.Play();
            Instantiate(bullet, parent.position + new Vector3(0.25f, 0, 0), parent.rotation);
            Instantiate(bullet, parent.position + new Vector3(-0.25f, 0, 0), parent.rotation);
            
        }
    }*/
}
