using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fogspawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MakeBullet()
    {
        // instantiate the object at xpos,ypos
        GameObject instance = Instantiate(prefab, new Vector3(xpos, ypos, 0), Quaternion.identity);

        // set the velocity of the instantiated object
        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(xvel, yvel, 0);
    }
