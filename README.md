# This is the dev setup for NetDaemon

Use this repository as template when developing apps for NetDaemon. Please note that NetDaemon is still under development.

## Getting started

1. Make new repository with this repo as template
2. Edit the daemon_config.json file to provide details about how to connect to Home Assistant. You will need a long lived token, ip, port.
3. Run dotnet restore in the terminal
4. Add and edit your apps in the apps folder. There are a few code-snippets you can use.
5. Copy the edited apps to the folder `netdaemon/apps` under your Hass.io config folder. Even more easy is to use HACS to deploy your APP to Home Assistant
6. Install the Hass.io add-on by adding the `https://github.com/helto4real/hassio-add-ons` to the add-on store and install NetDaemon
7. Run the add-on and check the log that your new apps is intitialized

For detailed information about netdaemon please see [https://helto4real.github.io/netdaemon/](https://helto4real.github.io/netdaemon/).
