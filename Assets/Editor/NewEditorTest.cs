﻿using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class NewEditorTest {

	[Test]
	public void EditorTest()
	{
		//Arrange
		var gameObject = new GameObject();

		//Act
		//Try to rename the GameObject
		var newGameObjectName = "My game object";
		gameObject.name = newGameObjectName;

		//Assert
		//The object has a new name
		Assert.AreEqual(newGameObjectName, gameObject.name);
	}

	[Test]
	public void 日本語テスト(){}

    [Test]
    public void 作った弾丸オブジェクトの名前チェック(){
        CameraController tes = new CameraController();
        GameObject go = tes.makeBullet();
        Assert.AreEqual("Bullet",go.name,"Bulletって言うオブジェクトが生成されてるはず");
    }

    [Test]
    public void 作った弾丸オブジェクトがPlayerから出力されているか座標チェック() {
        CameraController tes = new CameraController();
        GameObject gObject = tes.makeBullet();
        float x = gObject.transform.position.x;
        float y = gObject.transform.position.y;
        float z = gObject.transform.position.z;

        Assert.AreNotEqual(0,x,"Playerxから玉が発射されるのでx座標が0でなければOK");
        Assert.AreNotEqual(0,y,"Playerxから玉が発射されるのでy座標が0でなければOK");
        Assert.AreNotEqual(0,z,"Playerxから玉が発射されるのでz座標が0でなければOK");
    }

    [Test]
    public void spawnを取得する() {
        CameraController tes = new CameraController();
        GameObject go = tes.getSpawnObject();
        Assert.AreNotEqual(go, null, "spawnオブジェクトがNULLじゃないことを確認");
    }
}
