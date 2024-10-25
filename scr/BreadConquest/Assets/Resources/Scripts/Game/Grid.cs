using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    internal void CreateTile()
    {

    }

    internal OccupationType GetOccupation(Vector2 position)
    {
        return OccupationType.Air;
    }

    internal Occupant GetOccupant(Vector2 position)
    {
        return null;
    }

}
