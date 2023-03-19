using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System

public class Exercise03 : MonoBehaviour
{
    [SerializeField]
    private int x = 10;

    private void Awake()
    {
        int[][] array = new int[3][];

        array[0] = new int[3] { 1, 2, 3 };
        array[1] = new int[] { 10, 20, 30, 40 };
        array[2] = new int[] { 100, 200, 300, 400, 500 };

        for(int i = 0; i < array.Length; ++i)
        {
            for(int j = 0; j < array[i].Length; ++j)
            {
                Debug.Log($"[{i}][{j}] = {array[i][j]}");
            }
        }

        /*
        int[] enemys = new int[5];

        Debug.Log($"�迭�� Ÿ�� : {enemys.GetType()}");
        Debug.Log($"�迭�� �⺻ Ÿ�� : {enemys.GetType().BaseType}");

        Debug.Log("== ���� �� ==");
        for(int index=0; index < enemys.Length; ++index)
        {
            enemys[index] = UnityEngine.Random.Range(0, 100);

            Debug.Log(enemys[index]);
        }

        Array.Sort(enemys);

        Debug.Log("== ���� �� ==");
        for (int index=0; index < enemys.Length; ++index)
        {
            Debug.Log(enemys[index]);
        }

        Debug.Log($"Dimensions : {enemys.Rank}");

        /*
        int result = 0;
        int index = 1;

        while (index <= 100)
        {
            result += index;

            index++;
        }
        Debug.Log($"1���� 100������ ���� {result}");

        /* 05. �ݺ��� for
        for(int index = 0; index < 10; ++index)
        {
            Debug.Log(index);
        }

        for(int x = 1; x < 10; ++x)
        {
            for(int y = 1; y < 10; ++y)
            {
                Debug.Log($"{x} x {y} = {x * y}");
            }
        }
        /* 04. ���ǹ� switch - case
        x /= 10;

        switch (x)
        {
            case 10:
                Debug.Log("���� : A+");
                break;
            case 9:
                Debug.Log("���� : A+");
                break;
            case 8:
                Debug.Log("���� : B+");
                break;
            case 7:
                Debug.Log("���� : C+");
                break;
            case 6:
                Debug.Log("���� : D");
                break;
            default:
                Debug.Log("���� : F");
                break;
        }

        /*
        if (x >= 90)
        {
            Debug.Log("���� : A+");
        }
        else if (x >= 80)
        {
            Debug.Log("���� : B+");
        }
        else if (x >= 70)
        {
            Debug.Log("���� : C+");
        }
        else if (x >= 60)
        {
            Debug.Log("���� : D");
        }
        else
        {
            Debug.Log("���� : F");
        }

        /*
        if (x % 2 == 0)
        {
            Debug.Log("x�� ¦����");
        }
        else
        {
            Debug.Log("x�� Ȧ����");
        }

        if (x > 5 && x < 10)
        {
            Debug.Log("x�� 5���� ũ�� 10���� �۴�");
        }

        if (x > 5)
        {
            if (x < 10)
            {
                Debug.Log("x�� 5���� ũ�� 10���� �۴�");
            }
        }
        Debug.Log($"x�� ���� {x}");

        /*
        if (x % 2 == 0)
        {
            Debug.Log("x�� ¦����");
        }

        if (x > 5 && x < 10)
        {
            Debug.Log("x�� 5���� ũ�� 10���� �۴�");
        }
        if (x > 5)
        {
            if (x < 10)
            {
                Debug.Log("x�� 5���� ũ�� 10���� �۴�");
            }
        }
        Debug.Log($"x�� ���� {x}");
        */
    }
}
