using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CardManager.Instance.CreatCard(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
