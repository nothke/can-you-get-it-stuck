This repo is a little test about a strange behavior where Unity's GetMouseButton(N) gets stuck in true even if the mouse button is not pressed. 

See this tweet for a demo: https://twitter.com/Nothke/status/1474476187728728067 

Findings:
* Doesn't depend on losing focus of the app, the mouse is in the Game view at all times
* Doesn't depend on VSync, except that it's slighlty rarer with VSync off
* It definitely happens in editor, but in build I wasn't able to reproduce it. However, I am quite certain it happens, just rarer.
