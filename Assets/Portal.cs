using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    public AudioManager audioManager;

    bool isFirst = true;
    void OnBecameVisible()
    {
        if (isFirst)
        {
            audioManager.PlaySoundtrack("vita animarum");
            isFirst = false;
        }
        else return;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Corridors");
        }
        
    }
}
