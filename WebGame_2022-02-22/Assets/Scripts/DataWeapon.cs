using UnityEngine;

namespace BANE
{
    /// <summary>
    /// 武器資料
    /// 1.飛行速度
    /// 2.攻擊力
    /// 3.起始數量
    /// 4.最大數量
    /// 5.間隔時間
    /// 6.生成位置
    /// 7.武器預置物
    /// 8.飛行方向
    /// </summary>
    // ScriptableObject 腳本化物件
    // 作用：將腳本的資料變成物件儲存於 Project 內(擴充與維護性佳)
    // CreateAssetMenu 與 ScriptableObject 搭配使用
    // 作用：在Project 建立此腳本化物件的選單與檔案名稱
    // menuName 選單名稱、fileName 檔案名稱
    [CreateAssetMenu(menuName = "Bane/Data Weapon", fileName = "Data Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("飛行速度"), Range(0, 5000)]
        public float speed = 500;
        [Header("攻擊力"), Range(0, 100)]
        public float attack = 10;
        [Header("起始數量"), Range(1, 10)]
        public float countStart = 1;
        [Header("最大數量"), Range(1, 20)]
        public float countMax = 3;
        [Header("間隔時間"), Range(0, 5)]
        public float interval = 3.5f;

        // 資料類型[] 陣列 - 資料結構
        // 作用：儲存多筆相同類型的資料
        [Header("生成位置")]
        public Vector3[] v3SpawnPoint;
        [Header("武器預置物")]
        public GameObject goWeapon;
        [Header("飛行方向")]
        public Vector3 v3Direction;
    }
    public class DataWeapon1 : ScriptableObject
    {
        [Header("飛行速度"), Range(0, 5000)]
        public float speed = 350;
        [Header("攻擊力"), Range(0, 100)]
        public float attack = 7;
        [Header("起始數量"), Range(1, 10)]
        public float countStart = 3;
        [Header("最大數量"), Range(1, 20)]
        public float countMax = 6;
        [Header("間隔時間"), Range(0, 5)]
        public float interval = 1.5f;

        // 資料類型[] 陣列 - 資料結構
        // 作用：儲存多筆相同類型的資料
        [Header("生成位置")]
        public Vector3[] v3SpawnPoint;
        [Header("武器預置物")]
        public GameObject goWeapon;
        [Header("飛行方向")]
        public Vector3 v3Direction;
    }
}
