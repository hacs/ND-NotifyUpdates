using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;
public class HacsNotifyOnUpdate : NetDaemonApp
{
    public async override Task InitializeAsync()
    {
        Entity("sensor.hacs")
            .WhenStateChange((n, o) =>
                o?.State != n?.State )
                    .Call(async (entityId, newState, oldState) =>
                    {
                        var serviceData = new 
                        {
                            title = "Updates pending in HACS",
                            message = "There are updates pending in [HACS](/hacs)"
                        };
                        await CallService("persistent_notification", "create ", serviceData);
                    }).Execute();

    }
}