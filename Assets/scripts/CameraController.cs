using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public string prefabFolder_ = "Prefabs";
    public string prefabName_ = "BulletBase";
    private GameObject player;
    private GameObject spawn;

    //test用
    public CameraController(){
        init();
    }

	// Use this for initialization
	void Start () {
        init();
    }

    private void init(){
        //各種オブジェクトの取得
        this.spawn= GameObject.Find("Spawn");
        this.player = GameObject.FindGameObjectWithTag("Player");
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
        bullet = setAcceleration(bullet);
        return bullet; 
    }

    //オブジェクトを出現させる座標をPlayerの座標にする
    public GameObject setLocationPlayer(GameObject gObject) {
        Vector3 spawnPosition = spawn.transform.position;
        gObject.transform.position = spawnPosition + player.transform.forward;
        return gObject;
    }

    public GameObject getSpawnObject(){
        return this.spawn;
    }
    public GameObject getPlayerObject(){
        return this.player;
    }

    public GameObject setAcceleration(GameObject gObject){
        //rigitBodyの取得 
        Rigidbody rb = gObject.GetComponent<Rigidbody>();
        //        //playerの向いてる方向をrotationから取得する
        //        Quaternion playerRotation = player.transform.rotation;
        //        //playerの向いてる方向をvector3に変換する
        //        Vector3 playerForward = player.transform.forward;
        //        //加速度を与える
        float cameraRoutation = spawn.transform.rotation.x;
        Vector3 playerForward = spawn.transform.forward;
        rb.AddForce(playerForward*10, ForceMode.Impulse);
        return gObject;
    }
}

internal class Vectro3
{
}