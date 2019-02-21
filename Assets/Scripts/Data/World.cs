using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World {

    private Tile[,] map;

    public int Width { get; protected set; }
    public int Height { get; protected set; }

    public World(int width, int height) {
		Width = width;
		Height = height;
		map = new Tile[width, height];

		for (int x = 0; x < width; x++) {
			for(int y = 0; y < height; y++){
				map[x, y] = new Tile(x, y);
			}
		}
		RandomizeTiles();

    }

	public void RandomizeTiles() {
		for (int x = 0; x < Width; x++)
		{
			for (int y = 0; y < Height; y++)
			{
				map[x, y].tileId = Random.Range(0, 3);
			}
		}
	}

	public Tile getTileAt(int x, int y) {
		if (x > Width || x < 0 || y < 0 || y > Height)
			return null;

		return map[x, y];

	}

}
