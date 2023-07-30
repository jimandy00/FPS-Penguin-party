using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{

    public static ParticleManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public ParticleSystem particleSystem;
    public GameObject particleObject;

    public bool particleState = false;

    public void StartParticle()
    {
        particleState = true;
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
