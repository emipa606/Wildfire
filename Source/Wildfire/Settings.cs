using UnityEngine;
using Verse;

namespace Wildfire;

public class Settings : ModSettings
{
    public bool AllowLrgFire = true;

    public void DoWindowContents(Rect canvas)
    {
        var listing_Standard = new Listing_Standard { ColumnWidth = canvas.width };
        listing_Standard.Begin(canvas);
        listing_Standard.Gap();
        listing_Standard.CheckboxLabeled("WildFire.AllowLargeFire".Translate(), ref AllowLrgFire);
        if (Controller.currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("WildFire.CurrentModVersion".Translate(Controller.currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref AllowLrgFire, "AllowLrgFire", true);
    }
}