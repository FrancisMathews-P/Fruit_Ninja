using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorScript : MonoBehaviour
{
    public float speed;
    public Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * speed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
       
    }
}
