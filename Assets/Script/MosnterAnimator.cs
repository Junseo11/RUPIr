using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MosnterAnimator : MonoBehaviour
{

    private Animator anim;
    public UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update

 


    void Start()
    {
        anim = GetComponent<Animator>();
    

        Walk(true);
        Hit(false);



        
    }

    internal void stop(){

    }

    // Update is called once per frame
    void Update()
    {

        if(agent.speed>1.0f){
            Debug.Log("ssss");
            Run(true);
        }

    }

    void Walk(bool walk){
        anim.SetBool("Walk",walk);
    }
    void Run(bool run){
        anim.SetBool("Run",run);
    }

    void Hit(bool hit){
        anim.SetBool("Hit",hit);
    }
}
