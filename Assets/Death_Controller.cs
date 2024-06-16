using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Controller : MonoBehaviour{
   void Update(){
        if (transform.position.y < -100)
        {
            Debug.Log("Wpad³eœ do voida jak w mc");
            Time.timeScale = 0;
        } 
    }
}
