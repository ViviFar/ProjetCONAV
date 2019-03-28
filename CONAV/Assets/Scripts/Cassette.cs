using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Cassette : MonoBehaviour
{
    public AudioClip ac;

    public UnityEvent onMusicChange;

    public List<Cassette> autresCassettes;
<<<<<<< HEAD
    public ZoneManager zm;

    //the position of the tiroir to send the cassette
    public tiroir[] tiroirs;

=======

    //the position of the tiroir to send the cassette
    public Transform tiroir;

    //position of the stockage zone to send the previous playing cassette
    public Transform stockage;
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8

    [SerializeField]
    private bool isSelected;
    
    public AudioSource asource;
<<<<<<< HEAD

    private bool hasBeenSelectedAFirstTime = false;
=======
    
   
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Walkman" && !isSelected)
        {
            isSelected = true;
<<<<<<< HEAD
            if (hasBeenSelectedAFirstTime)
            {
                for (int i = 0; i < autresCassettes.Count; i++)
                {
                    autresCassettes[i].changeCassette();
                }
            }
            else
            {
                hasBeenSelectedAFirstTime = true;
=======
            for(int i =0; i < autresCassettes.Count; i++)
            {
                autresCassettes[i].changeCassette();
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8
            }
            asource.clip = ac;
            asource.Play();
            onMusicChange.Invoke();
        }
    }

    public void changeCassette()
    {
<<<<<<< HEAD
        foreach (tiroir t in tiroirs)
        {
            if (t.zoneTiroir == zm.zoneActuelle)
            {
                transform.position = t.transform.position;
            }
=======
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
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8
        }
    }
}
