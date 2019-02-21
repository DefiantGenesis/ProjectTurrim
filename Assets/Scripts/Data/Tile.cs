using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    public int X { get; protected set; }
    public int Y { get; protected set; }

    private World world;

    private int tile_id;
	public int tileId {
		get {
			return tile_id;
		}

		set {
			if (tile_id != value){
				tile_id = value;
				//call callback
			}
		}
	}

    public bool isPath { get; protected set; }

    public Tile(int x, int y, int tile_id = 0, bool isPath = false) {
        this.X = x;
        this.X = y;
        this.tile_id = tile_id;
        this.isPath = isPath;
    }

}
