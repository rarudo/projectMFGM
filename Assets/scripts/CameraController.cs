using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

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
        GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere); //球体の作成
        bullet.name = "Bullet";
        bullet = setLocationPlayer(bullet);
        return bullet; 
    }
    //オブジェクトを出現させる座標をPlayerの座標にする
    public GameObject setLocationPlayer(GameObject gObject) {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        gObject.transform.position = player.transform.position;
        return gObject;
    }
}
