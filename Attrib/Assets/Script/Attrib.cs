using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attrib : MonoBehaviour
{
    [Tooltip("Testing out attributes")]
    [Range(0,500)][SerializeField] private int number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
