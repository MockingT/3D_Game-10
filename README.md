# 3D_Game-10  
视频链接：http://www.iqiyi.com/w_19rym3ugpl.html
### 大致效果  
![avatar](https://github.com/MockingT/3D_Game-10/blob/master/pictures/result.png)  
### 实现步骤  
- 首先添加个一个空对象，在add component那里给他添加network manager以及network manager hud提供一个默认用户界面。  
![avatar](https://github.com/MockingT/3D_Game-10/blob/master/pictures/2.png)  
- 选择人物的预制，添加network identity属性，然后拖到networkmanager的spawn info中的player prefab，并且添加network transform，使得对象可以在网络中同步它的位置。  
![avatar](https://github.com/MockingT/3D_Game-10/blob/master/pictures/3.png)  
- 然后为了实现只有本地程序才能处理人物的移动，修改绑定到人物上的ActorController.cs上的代码。将MonoBehaviour更改为NetworkBehaviour。并且在Update函数中添加isLocalPlayer的检测。  
![avatar](https://github.com/MockingT/3D_Game-10/blob/master/pictures/4.png)
