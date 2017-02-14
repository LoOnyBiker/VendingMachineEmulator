-------

[![Build Status](https://travis-ci.org/LoOnyBiker/VendingMachineEmulator.svg?branch=develop)](https://travis-ci.org/LoOnyBiker/VendingMachineEmulator)
[![Build status](https://ci.appveyor.com/api/projects/status/06p7x5lifwro7h8p/branch/master?svg=true)](https://ci.appveyor.com/project/LoOnyBiker/vendingmachineemulator/branch/master)
[![Discord](https://img.shields.io/badge/Discord-%2FNoN%2Famer-green.svg)](https://discord.gg/pesvDPr)

-------

Данная работа выполняется в целях изучения и применения новых знаний и материала на практике. Возможно не лучшая из моих работ, тем не менее я стараюсь ;)

That project is living in purpose of studying new, to learn and sharpen skills on practice. May be not the best work for whole time, but I'm trying to do my best ;)

-------

#Постановка задачи

Напишите консольное приложение, эмулирующее взаимодействие покупателя с торговым автоматом с печеньками.

Автомат предлагает меню: кексы по 50р 4 шт., печенье по 10р 3 шт. и вафли по 30р 10шт.

Автомат принимает монеты номиналом 1, 2, 5, 10 рублей.

Покупатель имеет кошелёк, в нём 150р монетами данных номиналов.

Покупатель может вносить в автомат деньги, выбирать пункты меню и просить сдачу. Автомат выдаёт запрошенный предмет, если внесено достаточно денег.

Автомат выдаёт все не потраченные покупателем деньги, если у него запросили сдачу.

Автомат выдаёт сдачу минимальным количеством монет.



Обратите внимание на обработку ошибок, таких как:

   * у автомата нет монет на сдачу;

   * у автомата нет выбранного пункта меню;

   * внесённой суммы не хватает для покупки;

   * у человека кончились деньги в кошельке при попытке внести деньги в автомат.



Технические требования:

* Язык программирования: C#;

* Решение должно быть оформлено в виде репозитория на github.

Критерии оценки:

* Выполнение условий задачи;

* Следование ООП;

* Читаемость кода.


#Task

Write a console type application that emulate interaction between customer and vending machine with cookies.

Vending machine offers: 4 cakes for 50 rub each, 3 cookies for 10 rub each and 10 waffles for 30 rub each.

Machine allows customer to pay out with coins nominal 1, 2, 5 or 10 rubles.

Customer has wallet with 150 rubles coin nominals which were described before.

Customer could insert coin to machine, choose which good he wants and request change.

Machine is give all unspent money back to customer if he has requested that.

Machine is give change back with minimum of coins.


Notice few mistakes could be made such as:

    * Vending machine has no coins for change;

    * Machine has no chosen by customer item in menu;

    * Amount that customer's payed is not enough to complete deal;

    * Customer's money ends while he's inserting its into machine.

Technical requirements:

    * Language: C#;

    * Solution has to be a repo in github.

Criteria for evaluation:

    * Completed all the condition of task;

    * OOP inheritance;

    * Readable code.


# TO DO

    [checkbox:checked] Complit task simpliest way with tons of hardcode to figure out structure that I'm going to end with
    [checkbox:checked] Refactoring
    [checkbox:checked] ???
    [checkbox:checked] PROFIT!
