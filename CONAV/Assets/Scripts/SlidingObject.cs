using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingObject : MonoBehaviour
{
	Rigidbody rb;
	Vector3 initialPosition;
	public Vector3 translation;
	[Range(0,1)]
	public float speed;

	bool hasSlid = false;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = true;
		initialPosition = transform.position;
    }

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Slide();
		}
	}

	public void Slide()
	{
		if (!hasSlid)
		{
			StartCoroutine("SlideCoroutine");
			hasSlid = true;
		}
	}

	private IEnumerator SlideCoroutine()
	{
		float t = 0;
		while (Vector3.SqrMagnitude(transform.position-(initialPosition+translation)) > 0.01f)
		{
			t += speed * Time.deltaTime;
			transform.position = initialPosition + t * translation;
			yield return new WaitForEndOfFrame();
		}
	}
}
