using System;
using System.Collections;
using System.Collections.Generic;
using BLINDED_AM_ME;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    [SerializeField] private GameObject victim;
    [SerializeField] private Material material;
    
    // Start is called before the first frame update
    void Start()
    {
        MeshCut.Cut(victim, transform.position, transform.up, material);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(new Vector3(0, 0, -0.25f), new Vector3(1, 0, 0.5f));
    }
}
