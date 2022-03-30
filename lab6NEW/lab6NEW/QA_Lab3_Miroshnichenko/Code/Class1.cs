using System;
using System.Collections.Generic;
using System.IO;

namespace Dox_Test
{
    /// 
    /// @brief Интерфейс для приготовления оружия.
    /// 
    /// Создаёт общие методы для оружия, которые используются для подготовки войск.
    /// 
    interface Weapon
    {
        /// <summary>
        /// Метод обновления оружия
        /// </summary>
        void Renew();
        /// <summary>
        /// Метод отправки оружия.
        /// </summary>
        /// <param name="launch">Номер отправки.</param>
        void Use(int launch);
    }

    ///
    /// @brief Интерфейс для подготовки солдат.
    /// 
    /// СОздаёт общие методы для солдат, которые можно использовать для подготовки.
    /// 
    interface Soldiers
    {
        /// <summary>
        /// Метод подготовки солдат.
        /// </summary>
        void Prepare();
        /// <summary>
        /// Метод отправки солдат.
        /// </summary>
        void Send();
    }

    /// 
    /// @brief Класс для описания оружия для небольшого войска солдат.
    /// 
    /// Реализует интерфейс оружия. Отправка оружия для небольшого войска солдат.
    /// 
    class Small_ArmyWP : Weapon
    {
        /// Кол-вл готового оружия.
        private int weapons;
        public Small_ArmyWP()
        {
            this.Renew();
        }


        /// Метод, обновляющий поставку оружия.
        public void Renew()
        {
            this.weapons = 50;
        }
        /// <summary>
        /// Метод, реализующий поставку оружия, в зависимости от рейса поставки.
        /// </summary>
        /// <param name="launch">Номер рейса для отправки.</param>
        public void Use(int launch)
        {
            if (launch == 0)
            {
                this.weapons -= 5; ;
            }
            if(launch == 1)
            {
                this.weapons -= 15;
            }
        }
    }
    /// 
    /// @brief Класс для описания солдат для небольшой группы войска.
    /// 
    ///Реализует интерфейс солдат. Отправка солдат для небольшой группы войска.
    class Small_ArmyS : Soldiers
    {

        /// Кол-во готовых солдат.
        private int soldiers;

        /// <summary>
        /// Метод, обновляющий кол-во солдат для отправки.
        /// </summary>
        public void Prepare()
        {
            soldiers = 50;
        }
        /// <summary>
        /// Метод отправки солдат.
        /// </summary>
        public void Send()
        {
            soldiers -= 15;
        }
    }
    /// 
    /// @brief Класс для описания оружия для большого войска.
    /// 
    /// Реализует интерфейс оружия. Отправка оружия для большого войска солдат.
    /// 
    class Big_ArmyWP :Weapon
    {
        /// Кол-вл готового оружия.
        private int weapons;
        public Big_ArmyWP()
        {
            this.Renew();
        }

        /// Метод, обновляющий поставку оружия.
        public void Renew()
        {
            this.weapons = 400;
        }
        /// <summary>
        /// Метод, реализующий поставку оружия, в зависимости от рейса поставки.
        /// </summary>
        /// <param name="launch">Номер рейса для отправки.</param>
        public void Use(int launch)
        {
            if (launch == 0)
            {
                this.weapons -= 100;
            }
            if (launch == 1)
            {
                this.weapons -= 200;
            }
        }
    }

    /// 
    /// @brief Класс для описания солдат для большого войска.
    /// 
    ///Реализует интерфейс солдат. Отправка солдат для большого войска солдат.
    class Big_ArmyS : Soldiers
    {
        /// Кол-во готовых солдат.
        private int soldiers;

        /// <summary>
        /// Метод, обновляющий кол-во солдат для отправки.
        /// </summary>
        public void Prepare()
        {
            soldiers = 200;
        }

        /// <summary>
        /// Метод отправки солдат.
        /// </summary>
        public void Send()
        {
            soldiers -= 50;
        }
    }

    /// 
    /// @brief Класс для снаряжения армии.
    /// 
    /// Описывает снаряжение войска, включает в себя один объект, реализующий интерфейс оружия, и один объект, реализующий инферфейс солдат.
    /// Также имеет поле рейса отправки. 

    class Load_Army
    {
        /// Текущий рейс.
        protected int launch;
        /// Кол-во оружия.
        protected Weapon weapons;
        /// Колв-о солдат.
        protected Soldiers soldiers;
        /// <summary>
        /// Метод, устанавливающий кол-во оружия.
        /// </summary>
        /// <param name="weapon">Объект, реализующий интерфейс оружия.</param>
        public void Prepare_Weapons(Weapon weapon)
        {
            weapons = weapon;
        }
        /// <summary>
        /// Метод, устанавливающий кол-во Солдат.
        /// </summary>
        /// <param name="soldier">Объект, реализующий интерфейс солдат.</param>
        public void Prepare_Soldiers(Soldiers soldier)
        {
            soldiers = soldier;
        }
        /// <summary>
        /// Метод для инициализации всех полей.
        /// </summary>
        /// <param name="weapons">Объект, реализующий интерфейс оружия.</param>
        /// <param name="soldiers">Объект, реализующий интерфейс солдат.</param>
        public void Init(Weapon weapons, Soldiers soldiers)
        {
            launch = 0;
            this.weapons = weapons;
            this.soldiers = soldiers;
        }
        /// <summary>
        /// Метод, реализующий задачу, соответствующую заданной команде.
        /// </summary>
        public void Use()
        {
            this.weapons.Use(launch);
            this.soldiers.Send();
        }
        /// <summary>
        /// Метод, обновляющий состояние обхектов.
        /// </summary>
        public void Reset()
        {
            this.weapons.Renew();
            this.soldiers.Prepare();
        }
        /// <summary>
        /// Метод, увеличивающий номер рейса.
        /// </summary>
        public void NextLaunch()
        {
            launch++;
        }
        /// <summary>
        /// Метод, уменьшающий номер рейса.
        /// </summary>
        public void PrevLaunch()
        {
            launch--;
        }
    }
    /// @brief Класс для реализации Военного корабля.
    /// 
    /// Дочерний класс для описания снаряжения армии.
    /// Имеет метод для вычисления кол-ва человек на одно техническое устройство.
    class BattleShip:Load_Army
    {
        /// <summary>
        /// Метод для инициализации полей обхекта.
        /// </summary>
        /// <param name="weapons">Кол-во оружия.</param>
        /// <param name="soldiers">Кол-во солдат.</param>
        public void Init(Weapon weapons, Soldiers soldiers)
        {
            base.Init(weapons, soldiers);
        }

        /// <summary>
        /// Вычисление кол-ва человек на одно техническое устройство.
        /// Формула вычисления \f$\frac{x}{y}\f$
        /// </summary>
        /// <param name="tech">Кол-во техники.</param>
        /// <param name="people">Кол-во человек.</param>
        /// <returns>Кол-во человек на одно техническое устройство.</returns>
        public int People_to_Tech(int tech, int people)
        {
            return people / tech;
        }
    }

    ///@image html rabota.jpeg
    /// 
    /// @brief Класс для подготовки армии.
    /// 
    /// Имеет метод для подготовки армии в других частях программы.
    class Preparation
    {
        /// <summary>
        /// Метод для подготовки армии с заданной конфигурацией.
        /// </summary>
        /// <param name="conf1">Параметр, отвечающий за кол-во оружия.</param>
        /// <param name="conf2">Параметр, отвечающий за кол-во солдат.</param>
        /// <returns>Объект класса Load_Army с заданными параметрами.</returns>
        public Load_Army Loadout(int conf1, int conf2)
        {
            Load_Army Army = new Load_Army();
            if (conf1 == 1)
            {
                Small_ArmyWP smallwp = new Small_ArmyWP();
                Army.Prepare_Weapons(smallwp);
            }
            if (conf1 == 2)
            {
                Big_ArmyWP bigwp = new Big_ArmyWP();
                Army.Prepare_Weapons(bigwp);
            }
            if (conf2 == 1)
            {
                Small_ArmyS armyS = new Small_ArmyS();
                Army.Prepare_Soldiers(armyS);
            }
            if (conf2 == 2)
            {
                Big_ArmyS armyBig = new Big_ArmyS();
                Army.Prepare_Soldiers(armyBig);
            }
            return Army;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Preparation preparation = new Preparation();
            Load_Army army1 = preparation.Loadout(1, 2);
            Load_Army army2 = preparation.Loadout(2, 2);
        }
    }
}
