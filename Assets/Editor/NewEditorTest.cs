using UnityEngine;
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
}
