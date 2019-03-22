using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirCoffre : MonoBehaviour
{

    public GameObject key;
    public Animator animationCoffre;

    private bool open = false;
    private void Start()
    {

        animationCoffre.SetBool("isOpen", open);
    }

    //lancement de l animation lorsque la cle entre en contact avec le coffre
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            open = true;
            animationCoffre.SetBool("isOpen", open);
            Debug.Log("open : " + open);
        }
    }


    
        
    

}
