using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BigButton : MonoBehaviour
{
    public UnityEvent onClick;



    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onClick.Invoke();
        }
    }
}
