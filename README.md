#Deskripsi Aplikasi
Aplikasi yang dibuat adalah sebuah game 2D yang dibuat menggunakan platform Unity sebagai GameEngine nya. Game yang dibuat ini berupa game survival wave
dimana pengguna dapat menggerakan karakter dengan tombol W,A,S,D dan Left-Click mouse untuk menembak. Musuh akan datang untuk menghampiri player, jika musuh
terkena peluru player, maka player akan mendapatkan pointn sebesar 1. Jika musuh berhasil menyerang player, maka player akan terkena damage sebesar 10, sedangkan max health player adalah 100.

#Cara Kerja
Prefabs dari player menggunakan RigidBody2D sebagai logik fisika, dan menggunakan BoxColidder2D untuk mendeteksi sentuhan. Dibuat script untuk menggerakan karakter sesuai dengan input dari pengguna.
Terrain dibuat menggunakan TileMap untuk penggambarannya, dan BoxCollider2D untuk sentuhan. Terrain juga di scan menggunakan pathfinder agar musuh dapat menghindari terrain.
Musuh dibuat dengan BoxCollider2D untuk mendeteksi kontak fisik, tidak digunakan RigidBody2D karena musuh berupa burung yang terbang.
Untuk pencarian path menuju player, digunakan AIPathFinder yang dicari menggunakan algoritma A* (AStar).

#Library
Terdapat 2 library yang digunakan:
###CineMachine
Cinemachine digunakan untuk mempermudah camera fokus terhadap pemain. CineMachine mebuat sebuah kamera virtual dimana Main Camera akan selalu mengikutinya.

###AiPathFinder
AIPathFinder digunakan untuk tracking player sehingga musuh akan mengikuti player

#Screenshot Aplikasi
![alt text](https://gitlab.informatika.org/Willsen/if3210-2020-unity-13517036/ "Logo Title Text 1")
![alt text](https://gitlab.informatika.org/Willsen/if3210-2020-unity-13517036/ "Logo Title Text 1")