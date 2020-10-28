using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_bgm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }
        
    }

}
