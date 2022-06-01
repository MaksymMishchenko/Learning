Задание 2
Создайте свою пользовательскую сборку по примеру сборки CarLibrary из урока, сборка будет
использоваться для работы с конвертером температуры.

Решение:
-1. Создать интерфейс IConverter и два виртуальных метода ConvertToFahrenheit(double temperature), ConvertToKelvin(double temperature);
-2. Создать класс TemperatureConverter, реализовать интерфейс IConverter;
-3. Скомпилировать библиотеку, получить файл TemperatureConverter.dll