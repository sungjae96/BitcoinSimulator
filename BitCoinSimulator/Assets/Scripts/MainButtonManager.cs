using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonManager : MonoBehaviour
{
    public GameObject Main;
    public GameObject NewCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        Main.gameObject.SetActive(false);
        NewCanvas.gameObject.SetActive(true);
        GameObject.Find("Spawner").GetComponent<Spawner>().GoStop = false;
    }
}
