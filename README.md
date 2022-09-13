### logcord
See devices logged into your discord account.

# Archived
This repo is archived. That was a my project based on discord websockets and sessions, events. Discord now bringed **devices** features officialy, so this repo is unnecessary at this time. Will be in here for **researchs**!

## Why
This tool will give a very simple answer to people who think they have been **hacked**.

<details>
<summary>Story</summary>

After seeing weird actions on my account, i searched ways to see devices in my account. But no, there was no way.
I decided to make my own tool. Now open sourcing to those, who thinking "am i got hacked?".
</details>

## How?
> What happening when you logged-into your account? let me explain it.
* Your **platform, version** being collected.
* Discord creating a unique **session ID** and binds with those collected info.
* Even if discord won't fire following informations, they are also collected. [ip, country, full ver] etc.
* **Discord firing** `SessionUpdate` event with limited info collected about you.

**LogCord** listens to this event to be fired and collects device infos for you.

## You'll see
> Unfortunately, the informations are very limited. But enought to understand if you're hacked.
* Session ID
* Platform (**ex: android**)
* Version (**ex: 11.0**)

> If you see unrecognized device, that mostly means you're hacked.

## How to use
* Grab [release build](https://github.com/arshx86/LogCord/releases/tag/stable) and login with your token.
* Wait for the event to be fired (as soon as possible, discord will fire it)

<details>
<summary>Screenshots</summary>
<img src = "https://media.discordapp.net/attachments/921528250939883550/993594161972383844/unknown.png?width=836&height=468">
<br>
<img src = "https://media.discordapp.net/attachments/921528250939883550/993598987456221295/unknown.png?width=808&height=468">
</details>

## Notes
* Currently there are no way to evade from this. Means if you're hacked, hacker can't hide itself.
* Tool prevents from you being token terminated by discord. `with real connection strings`

## License
Licensed under **MIT**. Feel free to create contributons, issues. 

