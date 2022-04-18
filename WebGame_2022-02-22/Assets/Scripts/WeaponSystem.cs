using UnityEngine;

namespace BANE
{
    ///<summary>
    /// �Z���t��
    /// 1.�]�w���a���o���Z��
    /// 2.�ͦ��Z��
    /// 3.�o�g�Z��
    /// 4.�����O�x�s
    /// </summary>
    
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;

        //[SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon1;

        /// <summary>
        /// �p�ɾ�
        /// </summary>
        private float timer;

        // ø�s�ϥܨƥ� ODG
        // �@�ΡG�b�s�边�����U�ΡA�����ɤ����|�X�{
        private void OnDrawGizmos()
        {
            // 1. �M�w�ϥ��C��
            // Color(���A��A�šA�z����) - 0 ~ 1
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            // 2. ø�s�ϥ�
            // �ϥ�.ø�s�y��(�����I�A�b�|)
            // ���o�}�C��ƻP�k�G�}�C��ƦW��[���ޭ�]

            // for �j��G���ƳB�z�{���϶�
            // (��l��:����:�j�鵲���|����{��)
            for(int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
            }
            
            //Gizmos.color = new Color(1, 0, 0, 0.5f);
           
            //for (int i = 0; i < dataWeapon1.v3SpawnPoint.Length; i++)
           //{
           //     Gizmos.DrawSphere(transform.position + dataWeapon1.v3SpawnPoint[i], 0.1f);
           //}

        }

        private void Start()
        {
            // 2D ���z.�����ϼh�I��(�ϼh1�A�ϼh2)
            Physics2D.IgnoreLayerCollision(3, 6); // ���a �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 6); // �Z�� �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 7); // �Z�� �P ��� ���I��
        }

        private void Update()
        {
            SpawnWeapon();
            SpawnWeapon1();
        }

        /// <summary>
        /// �ͦ��Z��
        /// 1.�p��ɶ�
        /// 2.�ɶ��ֿn�춡�j�ɶ�
        /// 3.�ͦ��Z��
        /// 4.���w�b�ͦ���m�W
        /// 5.�o�g�Z��
        /// 6.�ᤩ�Z�������O
        /// </summary>
        private void SpawnWeapon()
        {
            // Time.deltaTime �@�Ӽv�檺�ɶ�
            timer += Time.deltaTime;

            //print("�g�L���ɶ�" + timer);

            // �p�G �p�ɾ� �j�󵥩� ���j�ɶ� �N�ͦ� �Z��

            if(timer >= dataWeapon.interval)
            {
                TopDownController.ani.Play("�u�\����");
                // print("�ͦ��Z��");
                // �H���� = �H��,�d��(�̤p�ȡA�̤j��) - ��Ƥ��]�t�̤j��
                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                // �y��
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                // Quaternion �|�줸:�������׸�T����
                // Quaternion.identity �s�ר�(0,0,0)
                // �Ȧs�Z�� = �ͦ�(����A�y�СA����)
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);
                // �Ȧs�Z��.���o����<����>().�K�[�ʤO(��V * �t��)
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);
                Destroy(temp, 5f);

                timer = 0;

            }
        }
        private void SpawnWeapon1()
        {
            // Time.deltaTime �@�Ӽv�檺�ɶ�
            timer += Time.deltaTime;

            //print("�g�L���ɶ�" + timer);

            // �p�G �p�ɾ� �j�󵥩� ���j�ɶ� �N�ͦ� �Z��

            if (timer >= dataWeapon1.interval)
            {
                // print("�ͦ��Z��");
                // �H���� = �H��,�d��(�̤p�ȡA�̤j��) - ��Ƥ��]�t�̤j��
                int random = Random.Range(0, dataWeapon1.v3SpawnPoint.Length);
                // �y��
                Vector3 pos = transform.position + dataWeapon1.v3SpawnPoint[random];
                // Quaternion �|�줸:�������׸�T����
                // Quaternion.identity �s�ר�(0,0,0)
                // �Ȧs�Z�� = �ͦ�(����A�y�СA����)
                GameObject temp = Instantiate(dataWeapon1.goWeapon, pos, Quaternion.identity);
                // �Ȧs�Z��.���o����<����>().�K�[�ʤO(��V * �t��)
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon1.v3Direction * dataWeapon1.speed);

                timer = 0;

            }
        }
    }
}