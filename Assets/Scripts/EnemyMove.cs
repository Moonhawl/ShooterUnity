using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    
    public Transform beg;
    public Transform end;
    private float speed = 0.005f;
    public int direction;
    public int sens;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sens == 1)
        {
            transform.position += Vector3.right * speed * direction;

            if (beg.position.x <= -9)
            {
                direction = 1;
            }
            if (end.position.x >= 10)
            {
                direction = -1;
            }
        }

        if (sens == 2)
        {
            transform.position += Vector3.left * speed * direction;

            if (beg.position.x <= -9)
            {
                direction = -1;
            }
            if (end.position.x >= 10)
            {
                direction = 1;
            }
        }

    }
}
