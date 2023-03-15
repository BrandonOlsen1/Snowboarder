using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float LoadDelay = 1f;
    [SerializeField] ParticleSystem finishEffects;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player") 
        {
            finishEffects.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", LoadDelay);
            
        }
        
   }



        void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }

}
