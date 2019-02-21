using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

	private World world;

	public Sprite[] sprites;

	void Start(){
		world = new World(100, 100);

		for (int x = 0; x < world.Width; x++) {
			for (int y = 0; y < world.Height; y++) {
				GameObject go = new GameObject();
				go.transform.position = new Vector3(x, y, 0);
				SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
				Tile t = world.getTileAt(x, y);
				sr.sprite = sprites[t.tileId];

			}
		}

    }

    void Update(){
        
    }

}
