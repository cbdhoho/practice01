using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise02 : MonoBehaviour
{
    private void Awake()
    {
        /*
        int a = 3;

        Debug.Log($"{a} << 1 = {a << 1}");
        Debug.Log($"{a} << 2 = {a << 2}");
        Debug.Log($"{a} << 3 = {a << 3}");
        Debug.Log($"{a} << 4 = {a << 4}");

        a = 255;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        a = -255;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        Debug.Log(Convert.ToString(a >> 4, 2));

        Debug.Log($"10 & 6 = {10 & 6}");

        Debug.Log($"10 | 6 = {10 | 6}");

        Debug.Log($"10 ^ 6 = {10 ^ 6}");

        Debug.Log($"~10 = {~10}");

        /* 10. ���� ������, ����(����) ������
        bool result = false;
        int x = 5, y = 2;

        result = x > 2 && y != 5;
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        result = x < 4 || y == 3;
        Debug.Log($"{x} < 4 || {y} == 3 = {result}");

        Debug.Log(result);
        result = !result;
        Debug.Log(result);

        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        Debug.Log("ü�� : " + hp);

        /* 09. ��(����) ������
        int x = 5, y = 2;

        Debug.Log($"{x} > {y} = {x > y}");
        Debug.Log($"{x} < {y} = {x < y}");
        Debug.Log($"{x} >= {y} = {x >= y}");
        Debug.Log($"{x} <= {y} = {x <= y}");
        Debug.Log($"{x} == {y} = {x == y}");
        Debug.Log($"{x} != {y} = {x != y}");

        /* 08. ���� ������
        int a = 10;
        Debug.Log(a);

        a++;
        Debug.Log(a);

        ++a;
        Debug.Log(a);

        Debug.Log(a++);
        Debug.Log(a);
        Debug.Log(++a);
        Debug.Log(a);

        /* 07. ����(�Ҵ�) ������
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : ��� �� {a}");

        Debug.Log($"a -= 9 : ��� �� {a -= 9}");
        Debug.Log($"a *= 8 : ��� �� {a *= 8}");
        Debug.Log($"a /= 7 : ��� �� {a /= 7}");
        Debug.Log($"a %= 6 : ��� �� {a %= 6}");
        Debug.Log($"a &= 5 : ��� �� {a &= 5}");
        Debug.Log($"a |= 4 : ��� �� {a |= 4}");
        Debug.Log($"a ^= 3 : ��� �� {a ^= 3}");
        Debug.Log($"a <<= 2 : ��� �� {a <<= 2}");
        Debug.Log($"a >>= 1 : ��� �� {a >>= 1}");

        /* 06. ��� ������
        int a = 5 + 6;
        int b = a - 3;
        int c = a * b;
        int d = c / 8;
        int e = d % 4;

        Debug.Log($"{a} = 5 + 6");
        Debug.Log($"{b} = {a} - 3");
        Debug.Log($"{c} = {a} * {b}");
        Debug.Log($"{d} = {c} / 8");
        Debug.Log($"{e} = {d} % 4");

        /* 05. ���ڿ� ����
        string position = "3,5,6";
        string[] str = position.Split(',');
        Debug.Log($"{str[0]}, {str[1]}, {str[2]}");

        string str2 = "HELLO, WORLD";

        str2 = str2.Substring(7);
        Debug.Log(str2);

        /* 04. ���ڿ� ����
        string str = "HELLO, WORLD";
        Debug.Log(str);

        str = str.ToLower();
        Debug.Log($"ToLower() - {str}");

        str = str.ToUpper();
        Debug.Log($"ToUpper() - {str}");

        str = str.Insert(0, "Hi~");
        Debug.Log($"Insert() - {str}");

        str = str.Remove(0, 4);
        Debug.Log($"Remove() - {str}");

        Debug.Log("== Trim ==");
        str = "    " + str + "    ";
        Debug.Log(str + "���� üũ");

        str = str.Trim();
        //str = str.TrimStart();
        //str = str.TrimEnd();
        Debug.Log(str + "���� üũ");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");
        Debug.Log($"After Replace : {str}");

        /* 03. ���ڿ� Ž��
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf('o');
        Debug.Log($"o�� �տ������� {numeric + 1}��°�� �ֽ��ϴ�.");

        numeric = str.LastIndexOf('o');
        Debug.Log($"o�� �ڿ������� {numeric}��°�� �ֽ��ϴ�.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} ������ Hello���� �����Ѵ�? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} ������ World���� �����Ѵ�? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} ������ Hello���� ������? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} ������ World���� ������? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} ���忡 Hell�� ���ԵǾ� �ִ�? {isTrue}");

        /* 02. string.Format() vs ���ڿ� ����
        int minutes = 1;
        int seconds = 15;

        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds));
        Debug.Log($"{minutes} : {seconds}");

        Debug.Log(string.Format("{0, -10:D5}", minutes));
        Debug.Log($"{minutes,-10:D5}");

        /* 01. string.Format()�� �̿��� ���ڿ� ����
        int minutes = 1;
        int seconds = 15;

        Debug.Log(string.Format("�⺻ : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("���� ���� : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("������ ���� : {0, 5}{1}{2}", minutes, ":", seconds));

        Debug.Log(string.Format("10���� ����ȭ : {0:D}", 123));
        Debug.Log(string.Format("10���� ����ȭ(5�ڸ�) : {0:D5}", 123));

        Debug.Log(string.Format("16���� ����ȭ : {0:X}", 0x00));
        Debug.Log(string.Format("16���� ����ȭ(10�ڸ�) : {0:X10}", 0x00));

        Debug.Log(string.Format("�����Ҽ��� ����ȭ : {0:F}", 1.23));
        Debug.Log(string.Format("�����Ҽ��� ����ȭ(�Ҽ��� 1�ڸ�) : {0:F1}", 1.23));

        Debug.Log(string.Format("�޸��� ���� : {0:N}", 1234567890));
        Debug.Log(string.Format("���� : {0:E}", 1234567890));

        DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)");
        Debug.Log(str);
        */
    }
}