using UnityEngine;


namespace BANE
{
    /// <summary>
    /// �ĤH����:�u�X���˼Ʀr
    /// </summary>
    // �l���O:�����O - �~�ӻy�k
    public class HurtEnemy : HurtSystem
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;

        private void Start()
        {
            hp = data.hp;
        }
    }
}

