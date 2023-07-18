using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AinimControll : MonoBehaviour
{
    public Animator anim;

    [SerializeField] private KeyCode jmpKey;
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private KeyCode rightKey;
    [SerializeField] private KeyCode backKey;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void Clean()
    {
        if (Input.GetKeyDown(jmpKey))
        {
            anim.SetTrigger("jump");
        }
        if (Input.GetKeyDown(leftKey))
        {
            anim.SetTrigger("right");

        }
        if (Input.GetKeyDown(rightKey))
        {
            anim.SetTrigger("left");

        }
        if (Input.GetKeyDown(backKey))
        {
            anim.SetTrigger("back");

        }
    }
    void Update()
    {
        if (anim != null)
        {
            Clean();
        }
    }
}