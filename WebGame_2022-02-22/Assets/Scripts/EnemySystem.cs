using UnityEngine;

namespace BANE
{
    /// <summary>
    /// 敵人系統
    /// </summary>
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "骷髏";

        private Transform traPlayer;

        float a = 0;
        float b = 1000;
        private void Awake()
        {
            // 玩家變形 = 遊戲物件.尋找(物件名稱) 的 變形
            traPlayer = GameObject.Find(namePlayer).transform;

            /** // 數學.插植(A，B，百分比)
            float result = Mathf.Lerp(0, 100, 0.5f);
            print("0 與 100 的 0.5 插植結果：" + result);
            */
        }
        
        private void Update()
        {
            /** 測試插植
            a = Mathf.Lerp(a, b, 0.5f);
            print("測試結果：" + a);
            */

            MoveToPlayer();
        }

        /// <summary>
        /// 移動到玩家位置
        /// </summary>
        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;          //A 點：敵人座標
            Vector3 posPlayer = traPlayer.position;         //B 點：玩家座標

            // 敵人座標 = 插植(敵人座標，玩家座標，百分比 * 速度 * 一貞的時間)
            transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

            // y = 敵人 X 大於 玩家 X ? 180 : 0 - 如果敵人 X 大於玩家 X 角度設定為 180 否則 0
            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }
    }
}

