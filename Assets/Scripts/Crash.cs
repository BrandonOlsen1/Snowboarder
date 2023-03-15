using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float LoadDelay = 1f;
    [SerializeField] ParticleSystem CrashEffects;
    bool crashed = false;


    [SerializeField] AudioClip crashSFX;
      void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !crashed) 
        {
            crashed = true;
            FindObjectOfType<PlayerController>().DisableControllers();
             CrashEffects.Play();
             GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", LoadDelay);
        }
        
   }

    void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }


}
