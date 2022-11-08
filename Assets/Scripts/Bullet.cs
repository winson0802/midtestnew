using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    public float atk = 50f;
    private Rigidbody rb;
    float lifeTime = 0;
    public string nextScene;
    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        lifeTime += Time.deltaTime;
        if (lifeTime > 2)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 如果碰撞到的是子彈
        if (other.tag == "Enemy")
        {
            // 刪除自己
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        // 判斷是否過關
            // 先取得目前所有 Tag 為 Coin 的物件陣列
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");

            // 如果陣列長度為0 （陣列內沒東西）
            if (objs.Length == 0)
            {
                // 切換到下一關
                SceneManager.LoadScene(nextScene);
            }
    
    }
}
