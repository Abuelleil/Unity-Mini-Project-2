using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

          if(Input.GetKey(KeyCode.W)){
                GetComponent<Animator>().SetBool("Walking", true);
                transform.Translate(0, 0,3f*Time.deltaTime);
            }else{
                GetComponent<Animator>().SetBool("Walking", false);

            }
            if(Input.GetKey(KeyCode.R)){
                GetComponent<Animator>().SetBool("Boxing", true);
            }else{
                GetComponent<Animator>().SetBool("Boxing", false);

            }
            if(Input.GetKey(KeyCode.A)){
                GetComponent<Animator>().SetBool("RoundHouseKick", true);
            }else{
                GetComponent<Animator>().SetBool("RoundHouseKick", false);

            }
            if(Input.GetKey(KeyCode.Q)){
                GetComponent<Animator>().SetBool("Kick1", true);
            }else{
                GetComponent<Animator>().SetBool("Kick1", false);

            }
            if(Input.GetKey(KeyCode.E)){
                GetComponent<Animator>().SetBool("Kick", true);
            }else{
                GetComponent<Animator>().SetBool("Kick", false);

            }
            if(Input.GetKey(KeyCode.F)){
                GetComponent<Animator>().SetBool("Uppercut", true);
            }else{
                GetComponent<Animator>().SetBool("Uppercut", false);

            }
            if(Input.GetKey(KeyCode.D)){
                GetComponent<Animator>().SetBool("QuadPunch", true);
            }else{
                GetComponent<Animator>().SetBool("QuadPunch", false);

            }
            if(Input.GetKey(KeyCode.S)){
                GetComponent<Animator>().SetBool("LegSweep", true);
            }else{
                GetComponent<Animator>().SetBool("LegSweep", false);

            }
            if(Input.GetKey(KeyCode.Z)){
                GetComponent<Animator>().SetBool("Chapeau", true);
            }else{
                GetComponent<Animator>().SetBool("Chapeau", false);

            }
    }
}
