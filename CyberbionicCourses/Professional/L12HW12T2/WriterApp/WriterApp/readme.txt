﻿Задание 2
Преобразуйте пример событийной блокировки таким образом, чтобы вместо ручной обработки
использовалась автоматическая.

Решение:
+1. Создать класс Writer, который содержит:
 + поле типа AutoResetEvent;
 + поле типа Thread;
 + конструктор;
 + метод Write():
  + в цикле выводит звездочки на экран 3 секунды;
  + на экземпляре вызывает метод Set(), который сообщвет главному потоку, чтобы тот продолжил работу;
+2. В методе Main() создать экземпляр класса AutoResetEvent;
+3. Создать экземпляр Writer и в конструктор передать экземпляр AutoResetEvent;
+4. Вызвать метод WaitOne() для приостановки выполнения главного потока.