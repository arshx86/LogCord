### logcord
See all devices on your account.

## Why?
This tool made to identifying the devices that using your account with scrapeable informations as possible.
By the shall of **OnSessionUpdated** event, you can gather the devices.

## How it work
When new device logs in to your account discord will fire [SessionUpdated](https://ilinked1337.gitbook.io/anarchy/documentation/clients/discordsocketclient#events#SessionUpdated) event which contains some limited infos about device.

**LogCord** listens to this event to be fired and collects device infos.

Show basic informations like **platform, version, session ID, OS** which is enough to determine whether you're hacked.
Can identify the **bots** (discord RPC clients, spotify)
User-Friendly GUI

## How to use
Compile or download [release build](https://github.com/arshx86/LogCord/releases/tag/stable) and prepare your token. Paste your token to app and you're ready.

![](https://media.discordapp.net/attachments/921528250939883550/993594161972383844/unknown.png?width=836&height=468)

> After login **logcord** will wait the session events from discord, when it fired (mostly few seconds after login) it will collect the all device infos and lists to you.

![](https://media.discordapp.net/attachments/921528250939883550/993598987456221295/unknown.png?width=808&height=468)

## Extra Features
* Hide **session id's** if needed. 
* Bypass for evading from account **termination**, by using  [real connection strings](https://github.com/arshx86/LogCord/blob/380b78e8d2cdfbe13f5986377f6dc993935a3bcc/src/Forms/Menu.cs#L194)
