﻿Создайте .xml файл, который соответствовал бы следующим требованиям:
 - имя файла: TelephoneBook.xml
 - корневой элемент: “MyContacts”
 - тег “Contact”, и в нем должно быть записано имя контакта и атрибут “TelephoneNumber”
со значением номера телефона.

Решение:
+1. Создать экземпляр класса XmlTextWriter, в конструктор передать имя документа с расширением .xml;
+2. Используя форматирование на классе обьекте обратиться к полям и установить тип форматирования;
+3. С помощью методов WriteStartDocument(), WriteStartElement(), WriteStartAttribute(), WriteString() построить дерево файла;
+4. Закрыть открытые раннее теги методом WriteEndElement и закрыть стрим для корректного сохранения данных в файл.