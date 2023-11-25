using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.XR;

public class Enemies : MonoBehaviour
{
    public float bulletSpeed;
    public Transform parent;
    public GameObject ennemiBullet;
    public GameObject ennemi;
    public GameObject bonus;
    private int chanceTir = 1;
    private int Tir = 0;
    private int bonusChance = 1;
    private int bonusDrop = 0;
    public AudioClip clip;
    public int hp =10;
    public int destroyedEnemies =0;
    

    AudioManager sfxEnemyDeath;

    // Start is called before the first frame update
    void Start()
    {
        sfxEnemyDeath = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Tir = Random.Range(0, 1999);
        if (Tir == chanceTir)
        {
            Instantiate(ennemiBullet, parent.position + Vector3.down, parent.rotation);

        }
    }
    public  void ReduceHP()
    {
        
        hp--;
        if(hp<=0)
        {
            
            sfxEnemyDeath.Play();
            Destroy(gameObject);
            destroyedEnemies++;
            bonusChance = Random.Range(0, 4);
            if (bonusDrop == bonusChance)
            {
                Instantiate(bonus, parent.position, parent.rotation);

            }

        }
    }


}
//*private void OnTriggerEnter2D(Collider2D collision)
//  {
//      Destroy(collision.gameObject);
//      Destroy(ennemiBullet);
 // }