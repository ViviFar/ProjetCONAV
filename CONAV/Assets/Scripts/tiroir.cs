using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class tiroir : MonoBehaviour
{
    public tiroir[] autresTiroirs;
    public ZoneManager zm;
    public Zone zoneTiroir;


    // Update is called once per frame
    void Update()
    {
        if(zoneTiroir != zm.zoneActuelle)
        {
            foreach (tiroir t in autresTiroirs)
            {
                for(int i=0; i< transform.childCount; i++)
                {
                    if(t.zoneTiroir == zm.zoneActuelle)
                    {
                        transform.GetChild(i).SetParent(t.transform);
                    }
                }
            }
        }
    }
}
