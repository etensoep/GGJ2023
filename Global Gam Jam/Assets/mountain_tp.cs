using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class mountain_tp: MonoBehaviour
{
     
     private void OnTriggerEnter2D( Collider2D other )
     {
         if ( other.CompareTag( "Player" ) )
         {
            string where = transform.name;
            switch(where) 
            {
              case "tp_start": 
                  string mount_to = "tp_end";
                  other.transform.position = new Vector3 (GameObject.Find(mount_to).transform.position.x - 3,
                   GameObject.Find(mount_to).transform.position.y, GameObject.Find(mount_to).transform.position.z);
                  break;
                
              case "tp_end": 
                  mount_to = "tp_start";
                  other.transform.position = new Vector3 (GameObject.Find(mount_to).transform.position.x + 7,
                   GameObject.Find(mount_to).transform.position.y, GameObject.Find(mount_to).transform.position.z);
                  break;
                }
         }
        }
}
