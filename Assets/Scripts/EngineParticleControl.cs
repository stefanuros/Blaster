using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineParticleControl : MonoBehaviour
{
    [HideInInspector]public new ParticleSystem particleSystem;

    // Use this for initialization
    void Start ()
    {
        particleSystem = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        var em = particleSystem.emission;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Start the engine particles by enabling emission
            em.enabled = true;
        }
        else
        {
            //If going from a playing state, turn off emission
            if (particleSystem.isPlaying)
            {
                em.enabled = false;
            }

        }
    }
}
