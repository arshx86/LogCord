### logcord
Scrape devices in your discord account.

## Identifying devices that using your account
> LogCord is made for identifying the devices that on your account as a limited way. Useful tool to determine whether you're **hacked**.

> I've made this tool because i was wondering if i hacked, i tested **session** requests, the events when you loginned to account. After a long researches i have made this tool and decided to make it open source as discord not bringed this shitty feature about **+6 years**.

## How it work
> When a device logins to your account, discord will create a new **session** for it and fire the **OnSessionUpdated** event with the some informations about the device.
> LogCord waits for this event from discord and gathers some informations about the device.

> As my tests, there are no evade **method** for bypassing device-detection. Hackers can't hide from this tool.

!! you can't see the **login pasts** with this tool, it only can show the **CURRENT** devices !!

## Features
* Show basic informations like **platform, version, session ID, OS** which is enough to determine whether you're hacked.
* Can identify the **bots** (discord RPC clients, spotify)
* User-Friendly GUI

## How to use
> Grab the standalone **release** build in **releases** and get your token. [Don't know how?](https://pcstrike.com/how-to-get-discord-token/), click to **manual** option and enter your token. Your token will be stored in **application resource** which can't be exploited.

![](https://media.discordapp.net/attachments/921528250939883550/993594161972383844/unknown.png?width=836&height=468)

> After login **logcord** will wait the session events from discord, when it fired (mostly few seconds after login) it will collect the all device infos and lists to you.

![](https://media.discordapp.net/attachments/921528250939883550/993598987456221295/unknown.png?width=808&height=468)

> When a new device is detected you'll get notification.

![](https://media.discordapp.net/attachments/921528250939883550/993598503974604920/unknown.png)

## Settings

> There are some settings to customize, you can hide session ID fields logout etc.
> There are **bypass** option which changes client's connection string to real ones. Like real browser version, real client version etc. to make discord think **you aren't using selfbot**.

![](https://media.discordapp.net/attachments/921528250939883550/993617260268752916/unknown.png?width=788&height=468)

## About Sessions
> A thing that discord creates when new device-login/enter to your account. Each device has private session ID

> Discord sessions actually stores your **full os detail, client version, device, browser details** and all of this infos encoded as **base64**.

> Unfortunately, the sessions which discord fires up doesn't contain these informations. But we can still know the limited informations, also you can't control the sessions you can only **SEE** it.

** All of your client, browser details also sent with **api/science** request. See in **x-super-properties** header as **base64** encoded string. **

![](https://media.discordapp.net/attachments/921528250939883550/993592887977709708/unknown.png)

If we decode it you'll get something like this.
```json
{
  "os": "Windows",
  "browser": "Discord Client",
  "release_channel": "stable",
  "client_version": "1.0.*",
  "os_version": "10.0.*",
  "os_arch": "x64",
  "system_locale": "tr",
  "client_build_number": 13914,
  "client_event_source": null
}
```

That's all my knowledge about the sessions, there are documentation or information nowhere about it. I hope this information is useful.

## Notes
* Using selfbot **may** cause termination of your account, **but i added a some bypasses for decrease chance of this**.
* Discord's session events is so limited, so tool **may not work in some cases**.
* If a hacker use this tool -- don't worry, he won't got anything (as session id is useless thing). But as you're owner of account you can know if you're hacked.
* `if you seeing a device that you don't know, reset your password and consider full re-install of discord`
* Discord has confirmed the **past login** feature coming soon in [this reddit post](https://www.reddit.com/r/discordapp/comments/vnq35u/discord_is_adding_a_way_to_see_and_manage_all/)
 
