﻿Дополнительное задание
Реализуйте шаблон NVI в собственной иерархии наследования.

Решение:
+1. Создать два класса - Employee и Teacher;
+2. Базовый класс Employee содержит виртуальный метод Learn() и виртуальный метод GetSalary(); эти методы вызываются из шаблонного метода public void DoWork();
+3. Класс Teacher наследуется от класса Employee b переопределяет в себе два метода из базового класса;
+4. В классе Program инстанцируем класс Teacher и приводим к базовому типу;
+5. Вызываем метод DoWork на экземпляре;