### Разработка программы по работе с реестром
В рамках работы изучались возможности редактирования реестра с помощью языка программирования C#.

Проект RegistryWork  должен был обладать функционалом:
1. Возможностью создания в разделе реестра HKEY_CURRENT_USER описаной в задании структуры ключей, а также их удаления.
2. Инструментарием для создания в ключах строковых параметров с установленными значениями, изменения этих значений и удаления одного из параметров.

Результат получения данных:
<p align="center"><img src="https://sun9-81.userapi.com/s/v1/if2/F-WKMa7LAiYWwf46ulHkdacs9RC7hYQlpmSZ530bPj-IRMsvZ9FXfwoT8WgJFT9Dd2IIq3uNMuuytENIQ9ypGOh2.jpg?size=642x422&quality=96&type=album"/> </p>
И их изменений:
<p align="center"><img src="https://sun9-42.userapi.com/s/v1/if2/yRHUbmMn3NfQM8FM14FwiAw0RyR_SK7LRdRxYH8eTW0NL_VooPkIUQwHwVmPEjos7aSQ5UtXFd7hrU8msWZseCMH.jpg?size=610x403&quality=96&type=album"/> </p>

### Разработка условно-бесплатной программы (работа с реестром)
В рамках работы разрабатывалось приложение, которое имеет ограниченное кол-во запусков. За основу программы был взят генератор паролей.

Программа PasswordGenerator при первом запуске должна в определенном разделе создавать параметр счетчик. При каждом запуске этот параметр считывается программой и увеличивается на 1. 

Приложение разрабатывалось в среде MS Visual Studio, поэтому разумным было хранить данные в Settings проекта. Для того, чтобы отследить первый запуск программы, прописывался параметр типа bool в User Scope (Область пользователя) с именем IsFirstRun и значением True. Чтобы было проще работать со значением количества запусков, создавалось два параметра типа int – RunCount, его значение мы и передаем в реестр, и DemoVersionCount, количество запусков до ограничения. DemoVersionCount нам изменять не придется, поэтому поставила область приложения.

<p align="center"><img src="https://sun9-53.userapi.com/s/v1/if2/0N21T6TBS8O1koONmfvM0Ybh069nPq5bL8SsOSX8Rzedq9QuQO0szKWaxibOOfzN2sdrRKmC5jzTq4tevdC3S_X-.jpg?size=355x116&quality=96&type=album"/> </p>

Такой способ хранения данных позволит во время разработки изменять IsFirstRun в xml файле, что упростит разработку.

При запуске выводится сообщение о количестве оставшихся запусков.

<p align="center"><img src="https://sun9-27.userapi.com/s/v1/if2/3m29Pl5oDpyns-7bFehR7MVo5AgKDJ2_2GsJm2gc94IhlNvtOtCrg3a9YYZMTTFaSxEXwfkvZ-wZXQisAWgIdVmb.jpg?size=246x246&quality=96&type=album"/> </p>

Если количество запуском программы превысило заданное в программе, пользователю запрещается использование программы.

<p align="center"><img src="https://sun9-85.userapi.com/s/v1/if2/bV2rx7y2D0PUo6trSTLdAb8-x6lRc0vePGbBCmlIq1t6Z2Ca1Iqbp_MuKDgX9ixuMT7wrthiilWCBCpnDoWjAD95.jpg?size=362x323&quality=96&type=album"/> </p>

### Инсталлятор
Разработка инсталлятора для каждой программы выполнялась при помощи Inno Setup и Advanced Installer. В папках представлены .exe файлы и скрипты 

Результат работы с Inno Setup:
<p align="center">
<img src="https://sun9-36.userapi.com/s/v1/if2/jTbwa_E3hFHhy3P6xTeSr4MZb6u9Y4CFzfsh_ihp0qtl6Qya54E9N15O3pMiWSRTIDVfs_JJzXPeMvWZlnohwBw_.jpg?size=231x97&quality=96&type=album"/> 
<img src="https://sun9-81.userapi.com/s/v1/if2/ng2RLIKFVkvGaFMUYm8niac2ElsxfKZK0_CqD8yrWCQ3EbcTa9CIKe6w7SaEBpzIhFLWi4mqHpSH9E9C237lKY4f.jpg?size=228x95&quality=96&type=album"/> 
</p>
