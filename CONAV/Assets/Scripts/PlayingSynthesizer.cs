using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingSynthesizer : MonoBehaviour {
    public Collider RightHand;
    public Collider LeftHand;
    private float timer = 0.0f;
    private float timerMusic = 0.0f;
    public float TimeLimit = 2.0f;
    private bool TimerIsRunning = false;
    public AudioClip FirstNote;
    public AudioClip Melody;
    private bool musicIsPlaying = false;
    public Cassette cassette;
<<<<<<< HEAD
    public AudioSource walkman;
=======
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8

    private AudioSource asr;

    private void Start()
    {
        cassette.gameObject.SetActive(false);
        asr = GetComponent<AudioSource>();
        asr.clip = FirstNote;
    }

    // Update is called once per frame
    void Update () {
        if (TimerIsRunning)
        {
            timer += Time.deltaTime;
            timerMusic += Time.deltaTime;
        }
        if (timer > TimeLimit)
        {
            asr.Stop();
<<<<<<< HEAD
            walkman.Play();
=======
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8
            timerMusic = 0;
            asr.clip = FirstNote;
            TimerIsRunning = false;
            musicIsPlaying = false;
            timer = 0.0f;
        }
<<<<<<< HEAD
        if (asr.clip==Melody && timerMusic > asr.clip.length)
=======
        if (timerMusic > asr.clip.length)
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8
        {
            //Faire poper la cassette
            cassette.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == RightHand || other == LeftHand)
        {
            if (!TimerIsRunning && !musicIsPlaying)
            {
                TimerIsRunning = true;
                asr.Play();
            }

            else if (TimerIsRunning && timer < TimeLimit)
            {
                if (!musicIsPlaying)
                {
                    asr.clip = Melody;
                    timerMusic = 0;
                    asr.Play();
                    musicIsPlaying = true;
<<<<<<< HEAD
                    walkman.Stop();
=======
>>>>>>> 0fa8e7fa417215911d99500bce8711754d194aa8
                }
                timer = 0.0f;
            }
            
        }
       
    }
}
