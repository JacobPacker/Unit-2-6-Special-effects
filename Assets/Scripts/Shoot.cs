using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        fire();
    }
    void fire()
    {
        if (Input.GetKeyDown("s"))
        {
            anim.Play("Firing");
        }
        
    }
}
