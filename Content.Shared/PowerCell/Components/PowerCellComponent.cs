using Content.Shared.Power.Components;
using Robust.Shared.GameStates;

namespace Content.Shared.PowerCell.Components;

/// <summary>
/// This component enables power-cell related interactions (e.g. EntityWhitelists, cell sizes, examine, rigging).
<<<<<<< HEAD
/// The actual power functionality is provided by the <see cref="BatteryComponent"/>.
=======
/// The actual power functionality is provided by the <see cref="PredictedBatteryComponent"/>.
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class PowerCellComponent : Component;
