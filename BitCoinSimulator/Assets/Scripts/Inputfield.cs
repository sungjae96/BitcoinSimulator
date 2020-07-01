using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inputfield : MonoBehaviour
{
    public int InputMoney;
    
    public InputField Iptmoney;    
    public GameObject explosion;
    public Text timerText;

    static int BankMoney;
    int GetMoney;
    int Luck;
    float time;
    public static bool stop = false;

    void Start()
    {
        Iptmoney.text = "0";
    }

    // Update is called once per frame
    void Update()
    { 
        if (GameObject.Find("MoneyText").GetComponent<MoneyController>().Money < int.Parse(Iptmoney.text))
        {
            InputMoney = GameObject.Find("MoneyText").GetComponent<MoneyController>().Money;
            Iptmoney.text = InputMoney.ToString();
        }

        if (stop)
        {
            time -= Time.deltaTime;
            timerText.text = "BankMoney : " + BankMoney  + "\nTimer :" + time;
            if(time <= 0)
            {
                OutBankMoney();
                stop = false;
            }
        }
    }

    public void PlayGambling2()
    {
        Luck = Random.Range(0, 100);

        if(Luck < 20)
        {
            GetMoney = int.Parse(Iptmoney.text) * 2;
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(GetMoney);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        else
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(-int.Parse(Iptmoney.text));
    }

    public void PlayGambling4()
    {
        Luck = Random.Range(0, 100);

        if (Luck < 15)
        {
            GetMoney = int.Parse(Iptmoney.text) * 4;
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(GetMoney);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        else
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(-int.Parse(Iptmoney.text));
    }

    public void PlayGambling6()
    {
        Luck = Random.Range(0, 100);

        if (Luck < 10)
        {
            GetMoney = int.Parse(Iptmoney.text) * 6;
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(GetMoney);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        else
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(-int.Parse(Iptmoney.text));
    }

    public void PlayGambling8()
    {
        Luck = Random.Range(0, 100);

        if (Luck < 5)
        {
            GetMoney = int.Parse(Iptmoney.text) * 8;
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(GetMoney);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        else
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(-int.Parse(Iptmoney.text));
    }

    public void PlayGambling10()
    {
        Luck = Random.Range(0, 100);

        if (Luck < 1)
        {
            GetMoney = int.Parse(Iptmoney.text) * 10;
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(GetMoney);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        else
            GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(-int.Parse(Iptmoney.text));
    }

    public void PutBankMoney()
    {
        BankMoney = int.Parse(Iptmoney.text);
        GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(-int.Parse(Iptmoney.text));
        SetTimer();        
    }

    public void SetTimer()
    {
        time = 60;
        stop = true;
    }

    void OutBankMoney()
    {
        GameObject.Find("MoneyText").GetComponent<MoneyController>().AddMoney(BankMoney * 2);
    }
}
