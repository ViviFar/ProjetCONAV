using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum nomZone
{
    A,
    B,
    C
}


public class Translation : MonoBehaviour
{
    //on se place dans le cas ou les plateaux sont disposes dans l ordre A B C selon x
    public Transform posA, posB, posC;
    public KeyCode moveZoneA, moveZoneB, moveZoneC;

    nomZone zone = nomZone.A;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //distance entre les 2 plateaux A et B (positive)
        Vector3 translationAB = posB.position - posA.position;
        //distance entre les 2 plateaux A et C (positive)
        Vector3 translationAC = posC.position - posA.position;
        //distance entre les 2 plateaux B et C (positive)
        Vector3 translationBC = posC.position - posB.position;


        switch (zone)
        {
            case (nomZone.A):
                //bouger sur plateau B
                if (Input.GetKeyDown(moveZoneB))
                {
                    transform.Translate(translationAB);
                    zone = nomZone.B;
                }
                //bouger sur plateau C
                if (Input.GetKeyDown(moveZoneC))
                {
                    transform.Translate(translationAC);
                    zone = nomZone.C;
                }
                break;
            case (nomZone.B):
                //bouger sur plateau A
                if (Input.GetKeyDown(moveZoneA))
                {
                    transform.Translate(-translationAB);
                    zone = nomZone.A;
                }
                //bouger sur plateau C
                if (Input.GetKeyDown(moveZoneC))
                {
                    transform.Translate(translationBC);
                    zone = nomZone.C;
                }
                break;
            case (nomZone.C):
                //bouger sur plateau B
                if (Input.GetKeyDown(moveZoneB))
                {
                    transform.Translate(-translationBC);
                    zone = nomZone.B;
                }
                //bouger sur plateau A
                if (Input.GetKeyDown(moveZoneA))
                {
                    transform.Translate(-translationAC);
                    zone = nomZone.A;
                }
                break;
            default:
                break;
        }

    }

}
