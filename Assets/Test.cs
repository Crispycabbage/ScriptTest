using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }
    public int Magic(int mp)
    {
        if(mp >= 5)
        {
            mp -=  5;
            Debug.Log("���@�U���������B�c��MP��" + mp);
            return mp;
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
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
