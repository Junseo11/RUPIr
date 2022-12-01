using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MonsterMove : MonoBehaviour
{

    public GameObject target;
    public UnityEngine.AI.NavMeshAgent agent;

    public static float speed=0.0f;



    public static bool isSafe=false; // 안전지대에 들어가 있는지 

    private float time=0.0f;


    // Start is called before the first frame update
    void Start()
    {

           
        
    }

    // Update is called once per frame
    void Update()
    {

        time+=Time.deltaTime/2;   //0.5초씩 speed 증가 

         agent.speed=3.5f+time;

      
        MoveToTarget(); //타겟으로 이동

        if(Input.GetKeyDown(KeyCode.R)){ //R키 누르면 재시작 

            agent.speed=3.5f;   //몬스터 속도 초기화 


            SceneManager.LoadScene("SampleScene");

        }
        
    }


    void MoveToTarget(){
        

        if(isSafe==false){
            agent.SetDestination(target.transform.position); //타겟의 위치로 목적지
        }
        else
        {
            agent.SetDestination(new Vector3(0,0,0)); //제자리걸음
        }
        
        
    }
}
