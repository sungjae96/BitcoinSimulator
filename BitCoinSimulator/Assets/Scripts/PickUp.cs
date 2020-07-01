using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    private GameObject target;
    private AudioSource sound;
    public AudioClip pickingsound;
    public GameObject pickingparticle;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = GetClickedObject();

            if (target.Equals(gameObject))  //선택된게 나라면
            {
                if (gameObject.tag == "coin")
                {                    
                    GameObject.Find("MoneyText").GetComponent<MoneyController>().Pickupmoney();                    
                    GameObject.Find("Spawner").GetComponent<Spawner>().spawncheck--;
                    sound.clip = pickingsound;
                    sound.Play();
                    Instantiate(pickingparticle, Input.mousePosition, transform.rotation);
                }
                else if (gameObject.tag == "1000")
                {
                    GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(1000);
                    GameObject.Find("Spawner").GetComponent<Spawner>().spawncheck--;
                }
                Destroy(gameObject);
                Destroy(pickingparticle, 5);
           }
        }

    }

    private GameObject GetClickedObject()
    {
        RaycastHit hit;

        GameObject target = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 



        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))   //마우스 근처에 오브젝트가 있는지 확인
        {
            //있으면 오브젝트를 저장한다.

            target = hit.collider.gameObject;

        }

        return target;

    }



}
