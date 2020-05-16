using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "New Partner Rule Tile", menuName = "Tiles/Partner Rule Tile")]
public class PartnerRuleTile : RuleTile
{
    public List<TileBase> partners;

    public override bool RuleMatch(int neighbor, TileBase other)
    {
        if (partners.Contains(other))
        {
            return true;
        } else {
            return false;
        }
    }
}