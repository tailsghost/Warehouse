# Тестовое задание для «Монополия»

## Разработать консольное .NET приложение для склада, удовлетворяющее следующим требованиям:

### Построить иерархию классов, описывающих объекты на складе - паллеты и коробки:

- Помимо общего набора стандартных свойств (ID, ширина, высота, глубина, вес), паллета может содержать в себе коробки.
- У коробки должен быть указан срок годности или дата производства. Если указана дата производства, то срок годности вычисляется из даты производства плюс 100 дней.
- Срок годности и дата производства - это конкретная дата без времени (например, 01.01.2023).
- Срок годности паллеты вычисляется из наименьшего срока годности коробки, вложенной в паллету. Вес паллеты вычисляется из суммы веса вложенных коробок + 30кг.
- Объем коробки вычисляется как произведение ширины, высоты и глубины.
- Объем паллеты вычисляется как сумма объема всех находящихся на ней коробок и произведения ширины, высоты и глубины паллеты.
- Каждая коробка не должна превышать по размерам паллету (по ширине и глубине).

### Консольное приложение:

- Получение данных для приложения можно организовать одним из способов:
- Генерация прямо в приложении
- Чтение из файла или БД
- Пользовательский ввод

### Вывести на экран:

- Сгруппировать все паллеты по сроку годности, отсортировать по возрастанию срока годности, в каждой группе отсортировать паллеты по весу.
- 3 паллеты, которые содержат коробки с наибольшим сроком годности, отсортированные по возрастанию объема.
- (Опционально) Покрыть функционал unit-тестами.
