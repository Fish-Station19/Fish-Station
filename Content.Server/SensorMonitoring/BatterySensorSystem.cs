using Content.Server.DeviceNetwork.Systems;
using Content.Server.Power.Components;
using Content.Shared.DeviceNetwork;
using Content.Shared.DeviceNetwork.Events;
using Content.Shared.Power.Components;
<<<<<<< HEAD
using Content.Shared.Power.EntitySystems;
=======
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)

namespace Content.Server.SensorMonitoring;

public sealed class BatterySensorSystem : EntitySystem
{
    public const string DeviceNetworkCommandSyncData = "bat_sync_data";

    [Dependency] private readonly DeviceNetworkSystem _deviceNetwork = default!;
<<<<<<< HEAD
    [Dependency] private readonly SharedBatterySystem _battery = default!;
=======
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)

    public override void Initialize()
    {
        SubscribeLocalEvent<BatterySensorComponent, DeviceNetworkPacketEvent>(PacketReceived);
    }

    private void PacketReceived(EntityUid uid, BatterySensorComponent component, DeviceNetworkPacketEvent args)
    {
        if (!args.Data.TryGetValue(DeviceNetworkConstants.Command, out string? cmd))
            return;

        switch (cmd)
        {
            case DeviceNetworkCommandSyncData:
                var battery = Comp<BatteryComponent>(uid);
<<<<<<< HEAD
                var currentCharge = _battery.GetCharge((uid, battery));
=======
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)
                var netBattery = Comp<PowerNetworkBatteryComponent>(uid);

                var payload = new NetworkPayload
                {
                    [DeviceNetworkConstants.Command] = DeviceNetworkCommandSyncData,
                    [DeviceNetworkCommandSyncData] = new BatterySensorData(
<<<<<<< HEAD
                        currentCharge,
=======
                        battery.CurrentCharge,
>>>>>>> 0f45621bc5 (Wizden: fresh start — single commit of current tree)
                        battery.MaxCharge,
                        netBattery.CurrentReceiving,
                        netBattery.MaxChargeRate,
                        netBattery.CurrentSupply,
                        netBattery.MaxSupply)
                };

                _deviceNetwork.QueuePacket(uid, args.SenderAddress, payload);
                break;
        }
    }
}
