using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class letsmakeit : MonoBehaviour
{
     public Transform[] target;
   public float speed;
   public int last;
  public string levelToLoad;
   private int current;



   void Update () {
   
   
   
    if(current != (target.Length))
    {
      NavMeshAgent agent = GetComponent<NavMeshAgent>();
      agent.SetDestination(target[current].transform.position);
   
     current=(current+1);


    }
   
   
    }
}