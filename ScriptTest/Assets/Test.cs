using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   //�̗�
    private int power = 25; // �U����

        // �U���p�̊֐�
        public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }
        //�h��p�̊֐�
        public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");

        //�c��HP�����炷
        this.hp = damage;
    }

    //�y���W�ۑ�zint�^�̕ϐ�mp��錾���A53�ŏ�����
    private int mp = 53;

    //�y���W�ۑ�zmp������Ė��@�U��������Magic�֐����쐬
    public void Magic()
    {
        if (this.mp >= 5)
            {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        //�U���p�̊֐����Ăяo��
        lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        //�y���W�ۑ�z���@�U���p�̊֐����Ăяo��
        lastboss.Magic();

        //�y���W�ۑ�zMagic�֐���10��g������ɁA�����Magic�֐����Ăяo���ƁAmp������Ȃ����b�Z�[�W��\��
        for (int n = 0; n < 10; n++)
        {
            lastboss.Magic();
        }


        Boss midboss = new Boss();

        //�U���p�̊֐����Ăяo��
        midboss.Attack();
        //�h��p�̊֐����Ăяo��
        midboss.Defence(10);


        //�y�ۑ�z�v�f�̌���5�́Aint�^�̔z��array��錾���ĔC�ӂ̒l�ŏ�����
        int[] Points = new int[5];
        Points[0] = 10;
        Points[1] = 20;
        Points[2] = 40;
        Points[3] = 30;
        Points[4] = 25;

        //�y�ۑ�z�z��̊e�v�f�̒l�����Ԃɕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(Points[i]);
        }

        //�y�ۑ�z�z��̊e�v�f�̒l���t���ɕ\������
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
