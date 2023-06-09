using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_animator1 : MonoBehaviour
{
    Animator animator;
    public static bool IsMove1 = false;


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsMove1", IsMove1);

        //PlayAnimation();
    }
    /*
    void PlayAnimation()
    {
        if (IsMove == false && Fertilize_on == false && Water_on == false && Shovel_on == false)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                animator.Play("Armature|Fertilize", -1, 0);
                Fertilize_on = true;
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                animator.Play("Armature|water", -1, 0);
                Water_on = true;
            }
        }
    }

    public void invisible_Fertilize_box()
    {
        if (Fertilize_on)
        {
            Fertilize_on = false;
        }
    }
    public void invisible_Water_box()
    {
        if (Water_on)
        {
            Water_on = false;
        }
    }
    */
}