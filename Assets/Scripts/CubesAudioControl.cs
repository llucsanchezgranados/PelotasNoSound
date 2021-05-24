using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesAudioControl : MonoBehaviour
{
	AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
	Mesh mesh = GetComponent<MeshFilter>().mesh;	
	Bounds bounds = mesh.bounds;
	source.pitch = 1.0f / bounds.size.x;
	print(bounds.size.x);

    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnCollisionEnter(Collision collision)
	
     {
	Renderer rend = GetComponent<Renderer>();
	Bounds bounds = rend.bounds;
	source.pitch = 1.0f / bounds.size.x;
	print( "collision: " + bounds.size.x);
	source.Play();
     }
}
