using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour {

    private Text MoneyText;
    public int Money;
    public bool paycheck;

    public float minmoney;
    public float maxmoney;
    private AudioSource buysound;

    // Use this for initialization
    void Start () {
        Money = 0;
        MoneyText = GetComponent<Text>();
        paycheck = false;

        minmoney = 10;
        maxmoney = 1000;
        buysound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        MoneyText.text = "  "+ Money;
    }

    public void AddMoney(int Add)
    {
        Money += Add;
    }

    public void buyitem(int cost)
    {
        if (Money >= cost)
        {
            buysound.Play();
            Money -= cost;
            paycheck = true;
        }
        else
            paycheck = false;
    }

    public bool Getpaycheck()
    {
        return paycheck;
    }

    public void Pickupmoney()
    {
        Money += (int)Random.Range(minmoney, maxmoney);
    }

    public void MaxMoneyUpgarde()
    { 
        if (Getpaycheck())
            maxmoney += 1000;
    }

}
