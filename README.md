# UNetSyncVarBug
Demonstrating SyncVar bug introduced in Unity 2018.2 and later

Steps to reproduce:
1. Build and run project.
2. Press 'H' key.
3. Play in editor.
4. Press 'C' key.
5. Switch to the stand-alone window and press space.
6. Switch to the editor and see the console message:
    * In 2018.1.9f2: player name is set to"test".    
    * In 2018.2.20f1: player name is set to"".
