using Content.Server.Power.EntitySystems;
using Content.Server.Xenoarchaeology.Artifact.XAE.Components;
using Content.Shared.Power.Components;
using Content.Shared.Power.EntitySystems;
using Content.Shared.Xenoarchaeology.Artifact;
using Content.Shared.Xenoarchaeology.Artifact.XAE;

namespace Content.Server.Xenoarchaeology.Artifact.XAE;

/// <summary>
/// System for xeno artifact activation effect that is fully charging batteries in certain range.
/// </summary>
public sealed class XAEChargeBatterySystem : BaseXAESystem<XAEChargeBatteryComponent>
{
    [Dependency] private readonly BatterySystem _battery = default!;
<<<<<<< HEAD
=======
    [Dependency] private readonly PredictedBatterySystem _predictedBattery = default!;
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)
    [Dependency] private readonly EntityLookupSystem _lookup = default!;

    /// <summary> Pre-allocated and re-used collection.</summary>
    private readonly HashSet<Entity<BatteryComponent>> _batteryEntities = new();
<<<<<<< HEAD
=======
    private readonly HashSet<Entity<PredictedBatteryComponent>> _pBatteryEntities = new();
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)

    /// <inheritdoc />
    protected override void OnActivated(Entity<XAEChargeBatteryComponent> ent, ref XenoArtifactNodeActivatedEvent args)
    {
        _batteryEntities.Clear();
<<<<<<< HEAD
=======
        _pBatteryEntities.Clear();
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)

        _lookup.GetEntitiesInRange(args.Coordinates, ent.Comp.Radius, _batteryEntities);
        foreach (var battery in _batteryEntities)
        {
            _battery.SetCharge(battery.AsNullable(), battery.Comp.MaxCharge);
        }
<<<<<<< HEAD
=======

        _lookup.GetEntitiesInRange(args.Coordinates, ent.Comp.Radius, _pBatteryEntities);
        foreach (var pBattery in _pBatteryEntities)
        {
            _predictedBattery.SetCharge(pBattery.AsNullable(), pBattery.Comp.MaxCharge);
        }
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)
    }
}
