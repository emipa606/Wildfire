using UnityEngine;
using Verse;

namespace Wildfire
{
    // Token: 0x02000004 RID: 4
    public class Settings : ModSettings
    {
        // Token: 0x04000002 RID: 2
        public bool AllowLrgFire = true;

        // Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
        public void DoWindowContents(Rect canvas)
        {
            var listing_Standard = new Listing_Standard {ColumnWidth = canvas.width};
            listing_Standard.Begin(canvas);
            listing_Standard.Gap();
            listing_Standard.CheckboxLabeled("WildFire.AllowLargeFire".Translate(), ref AllowLrgFire);
            listing_Standard.Gap();
            listing_Standard.End();
        }

        // Token: 0x06000006 RID: 6 RVA: 0x000020F5 File Offset: 0x000002F5
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref AllowLrgFire, "AllowLrgFire", true);
        }
    }
}