using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public string prefabFolder_ = "Prefabs";
    public string prefabName_ = "BulletBase";

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            makeBullet();
        }
    }
    public GameObject makeBullet() {
        //弾丸を作成プレハブから持ってくる
        string prefabName = prefabFolder_ + "/" + prefabName_;
        GameObject bullet = Instantiate(Resources.Load(prefabName)) as GameObject;
        bullet.name = "Bullet";
        bullet = setLocationPlayer(bullet);
        return bullet; 
    }

    //オブジェクトを出現させる座標をPlayerの座標にする
    public GameObject setLocationPlayer(GameObject gObject) {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 playerPosition = player.transform.position;
        gObject.transform.position = playerPosition + player.transform.forward;
        return gObject;
    }
}
