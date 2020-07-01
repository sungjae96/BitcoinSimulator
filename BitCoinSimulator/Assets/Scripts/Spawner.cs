using UnityEngine;
using System.Collections;
public class Spawner : MonoBehaviour
{
    public GameObject[] Money;

    public float interval = 5;
    public int spawncheck = 0;
    public int Maxspawn = 20;
    private int objectindex = 0;
    public bool GoStop = true;
    // Use this for initialization
    IEnumerator Start()
    {
        while (GoStop)
        {
            if (spawncheck < Maxspawn)
            {
                objectindex = Random.Range(0, 2);
                transform.position = new Vector3(Random.Range(30, 300),Random.Range(130, 530), transform.position.z);

                Instantiate(Money[objectindex], transform.position, transform.rotation);
                spawncheck++;
            }
            yield return new WaitForSeconds(interval);

        }
    }
    // Update is called once per frame
    void Update()
    {
    }

    public void setGostoptrue()
    {
        GoStop = true;
    }

    public void Maxspawnupgrade()
    {
        bool check;

        check = GameObject.Find("MoneyText").GetComponent<MoneyController>().Getpaycheck();
        if (check)
            Maxspawn++;
    }

    public void Spawntimeupgrade()
    {
        bool check;

        check = GameObject.Find("MoneyText").GetComponent<MoneyController>().Getpaycheck();
        if (check)
            interval -= 0.2f;
    }
}