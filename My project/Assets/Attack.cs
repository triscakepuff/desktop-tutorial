using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("goAttack");
            
        }
        
    }
}
