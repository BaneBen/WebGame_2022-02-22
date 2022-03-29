using UnityEngine;

namespace Bane
{
    /// <summary>
    /// �Z�����
    /// 1.����t��
    /// 2.�����O
    /// 3.�_�l�ƶq
    /// 4.�̤j�ƶq
    /// 5.���j�ɶ�
    /// 6.�ͦ���m
    /// </summary>
    // ScriptableObject �}���ƪ���
    // �@�ΡG�N�}��������ܦ������x�s�� Project ��(�X�R�P���@�ʨ�)
    // CreateAssetMenu �P ScriptableObject �f�t�ϥ�
    // �@�ΡG�bProject �إߦ��}���ƪ��󪺿��P�ɮצW��
    // menuName ���W�١BfileName �ɮצW��
    [CreateAssetMenu(menuName = "Bane/Data Weapon", fileName = "Data Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float speed = 500;
        [Header("�����O"), Range(0, 100)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(1, 10)]
        public float countStart = 1;
        [Header("�̤j�ƶq"), Range(1, 20)]
        public float countMax = 3;
        [Header("���j�ɶ�"), Range(0, 5)]
        public float interval = 3.5f;

        // �������[] �}�C - ��Ƶ��c
        // �@�ΡG�x�s�h���ۦP���������

        [Header("�ͦ���m")]
        public Vector3[] v3SpawnPoint;
    }
}
