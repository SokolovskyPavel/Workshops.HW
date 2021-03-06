﻿using System.Collections.Generic;

namespace Rocket.BL.Common.Models.UserRoles
{
    public class Role : BllEntity
    {
        /// <summary>
        /// Название роли пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// список пермишенов для роли
        /// </summary>
        public virtual ICollection<Permission> Permissions { get; set; }

        /// <summary>
        /// список юзеров с ролью
        /// </summary>
        public virtual ICollection<User.User> Users { get; set; }
    }
}