﻿Задание 3
Создайте приложение, которое может быть запущено только в одном экземпляре (используя
именованный Mutex).

Решение:
+1. Создать экземпляр класса Mutex(false, MyMutex::GUID);
+2. В методе Main() на экземпляре Mutex вызвать метод WaitOne();
+3. Вывести сообщение с id потока; 
+4. Вызвать метод Console.ReadKey() - чтобы вызвать задержку;
+5. Освободить поток вызвав метод ReleaseMutex.