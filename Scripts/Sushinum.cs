using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sushinum : MonoBehaviour
{
    public Text sushi;
    // Start is called before the first frame update
    void Start()
    {
        int to_sushi =  serveplate.servedSushi/3;
        sushi.text = to_sushi.ToString();
        serveplate.servedSushi = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
