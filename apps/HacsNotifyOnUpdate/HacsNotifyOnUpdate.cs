using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;
public class HacsNotifyOnUpdate : NetDaemonApp
{
    public async override Task InitializeAsync() => Entity("sensor.hacs")
            .WhenStateChange((n, o) =>
                o?.State != n?.State && n?.State > 0)
                    .Call(async (entityId, newState, oldState) =>
                    {
                        await CallService("persistent_notification", "create", new
                        {
                            title = "Updates pending in HACS",
                            message = "There are updates pending in [HACS](/hacs)"
                        }, true);
                    }).Execute();
}