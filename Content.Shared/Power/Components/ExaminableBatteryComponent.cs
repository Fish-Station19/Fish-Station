using Robust.Shared.GameStates;

namespace Content.Shared.Power.Components;

/// <summary>
/// Allows the charge of a battery to be seen by examination.
<<<<<<< HEAD
/// Requires <see cref="BatteryComponent"/>.
=======
/// Works with either  <see cref="BatteryComponent"/> or <see cref="PredictedBatteryComponent"/>.
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ExaminableBatteryComponent : Component;
