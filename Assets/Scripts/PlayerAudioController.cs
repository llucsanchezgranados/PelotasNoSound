using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
	AudioSource[] sources;
	Rigidbody rb;
	float speed = 0.0f;
	bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();
	rb = GetComponent<Rigidbody>();
	sources[0].Play();
	
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;
	if (speed > 0.1f && !isPlaying) {
		isPlaying = true;
		sources[0].Play();

	} else if (speed < 0.2f) {
		isPlaying = false;
		sources[0].Stop();
	}
	sources[0].pitch = speed / 2.0f;
    }

	void OnCollisionEnter(Collision collision)
	{
	sources[1].Play(); 
	}


}
