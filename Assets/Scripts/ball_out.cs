using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
// Use this for initialization
void Start()
{

    }

    // Update is called once per frame
void Update()
{
        // 左クリック押したら、効果音を鳴らす
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }
}
}

