# Rust-Bundles-Pre-Loader
I just wrote a little console application that pre-loads the Rust assets/bundles
directly to your Memory in a faster way than Rust itself does.
Rust Bundles Pre-Loader does almost the same thing as RAMDisk but, only loads the assets which are the biggest files.
And doesn't make virtual Ram drives. It basically puts the files in your Memory for Rust to pick it up.
The same thing happens when you start Rust and close it.
The Assets will still be in your Memory so you can load Rust faster at later time (without rebooting ofcourse).

You need to set the path for the :<br>
<B>assets.bundle</B>, <B>content.bundle</B>, <B>monuments.bundle</B>, <B>textures.bundle</B> and <B>maps.bundle</B><br>
inside the <B>config.txt</B> file.<br>
The Bundles are located here: <B>steamapps\common\Rust\Bundles</B><br>
Just run it when you have set the <B>config.txt</B> file and wait untill it closes.

<br>
<br>

<b>My Specs:</b><br>
GPU: GeForce RTX 2080 8GB<br>
CPU: Intel(R) Core(TM) i7-8700K CPU @ 4.80GHz<br>
Memory: 16.00 GB DDR4<br>

<br>

<b>Loading speed benchmark:</b><br>
Normal: MainMenu : 2:29 | Join Server : 1:15<br>
Preloaded Bundles: MainMenu : 0:11 | Join Server : 0:49<br>
Preloader Application: 0:59<br>
<br>
<img align="left" src="https://chrisandriessen.nl/web/img/RustBPL.png">
