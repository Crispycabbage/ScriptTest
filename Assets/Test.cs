using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    public int Magic(int mp)
    {
        if(mp >= 5)
        {
            mp -=  5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
            return mp;
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
            return mp;
        }

    }

}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 11, 12, 13, 14, 15 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length-1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }


        Boss lastboss = new Boss();
        int mp = 53;
        for (int i = 0; i < 11; i++)
        {
            int num=lastboss.Magic(mp);
            mp= num;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
