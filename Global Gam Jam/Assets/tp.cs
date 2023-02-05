using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class tp : MonoBehaviour
{
     
     private void OnTriggerEnter2D( Collider2D other )
     {
         if ( other.CompareTag( "Player" ) )
         {
            string where = transform.name;

            switch(where) 
            {
              case "blue_tp": 
              string to = "black_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x - 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
                break;

              case "black_tp":
               to = "purple_tp";
               other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x - 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;

              case "brown_tp":
              to = "yellow_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x - 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;

              case "cyan_tp":
              to = "emerald_tp";
               other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x + 5,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;

              case "lilac_tp":
              to = "blue_tp";
               other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x - 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;
              
              case "green_tp":
              to = "lilac_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x - 5,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;

              case "grey_tp":
              to = "white_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x + 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;
                            

              case "emerald_tp":
              to = "brown_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x + 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;

              case "purple_tp":
              to = "grey_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x + 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;


              case "orange_tp":
               to = "cyan_tp";
               other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x - 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
                break;

              case "white_tp":
               to = "light_yellow_tp";
               other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x + 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;

            case "yellow_tp":
            to = "red_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x - 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;
            
            case "red_tp":
            to = "orange_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x + 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;
            
            case "light_yellow_tp":
            to = "green_tp";
              other.transform.position = new Vector3 (GameObject.Find(to).transform.position.x + 10,
               GameObject.Find(to).transform.position.y, GameObject.Find(to).transform.position.z);
               break;



              case "exit":
              SceneManager.LoadScene("level 2");
              break;
            }
         }
     }

}
