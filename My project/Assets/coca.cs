using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coca : MonoBehaviour
{
    private Animator animator;
    public int estadio;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("estadio", estadio);
    }
}
