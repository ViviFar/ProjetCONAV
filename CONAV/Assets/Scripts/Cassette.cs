using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Cassette : MonoBehaviour
{
    public AudioClip ac;

    public UnityEvent onMusicChange;

    public List<Cassette> autresCassettes;

    //the position of the tiroir to send the cassette
    public Transform tiroir;

    //position of the stockage zone to send the previous playing cassette
    public Transform stockage;

    [SerializeField]
    private bool isSelected;
    
    public AudioSource asource;
    
   


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Walkman" && !isSelected)
        {
            isSelected = true;
            for(int i =0; i < autresCassettes.Count; i++)
            {
                autresCassettes[i].changeCassette();
            }
            asource.clip = ac;
            asource.Play();
            onMusicChange.Invoke();
        }
    }

    public void changeCassette()
    {
        //if this was the cassette playing, we store it in the stockage pos
        if (isSelected)
        {
            isSelected = false;
            transform.position = stockage.position;
        }
        //else we stock it in the tiroir
        else
        {
            transform.position = tiroir.position;
        }
    }
}
