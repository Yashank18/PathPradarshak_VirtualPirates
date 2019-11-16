using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform[] target;
   public float speed;
  
   private int current;



   void Update () {
   
    
    
    if (transform.position != target[current].position)
    {
      Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
      GetComponent<Rigidbody>().MovePosition(pos);
    this.transform.LookAt(target[current].position);
    
    


    }
    else {
        if(current == (target.Length))
        {
          return;
        }
        else
      current=(current+2);
  
         
      }
    }
    
   
}
