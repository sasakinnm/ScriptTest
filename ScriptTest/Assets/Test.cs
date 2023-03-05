using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   //体力
    private int power = 25; // 攻撃力

        // 攻撃用の関数
        public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
        //防御用の関数
        public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        //残りHPを減らす
        this.hp = damage;
    }

    //【発展課題】int型の変数mpを宣言し、53で初期化
    private int mp = 53;

    //【発展課題】mpを消費して魔法攻撃をするMagic関数を作成
    public void Magic()
    {
        if (this.mp >= 5)
            {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //【発展課題】魔法攻撃用の関数を呼び出す
        lastboss.Magic();

        //【発展課題】Magic関数を10回使った後に、さらにMagic関数を呼び出すと、mpが足りないメッセージを表示
        for (int n = 0; n < 10; n++)
        {
            lastboss.Magic();
        }


        Boss midboss = new Boss();

        //攻撃用の関数を呼び出す
        midboss.Attack();
        //防御用の関数を呼び出す
        midboss.Defence(10);


        //【課題】要素の個数が5つの、int型の配列arrayを宣言して任意の値で初期化
        int[] Points = new int[5];
        Points[0] = 10;
        Points[1] = 20;
        Points[2] = 40;
        Points[3] = 30;
        Points[4] = 25;

        //【課題】配列の各要素の値を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(Points[i]);
        }

        //【課題】配列の各要素の値を逆順に表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(Points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
