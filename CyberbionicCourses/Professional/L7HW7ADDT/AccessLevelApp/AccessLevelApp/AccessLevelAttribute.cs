using System;

namespace AccessLevelApp
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class AccessLevelAttribute : Attribute
    {
        private AccessLevel _accessLevel;
        public string Name { get; set; }
        public string Position { get; set; }

        public AccessLevelAttribute(AccessLevel accessLevel)
        {
            _accessLevel = accessLevel;
        }
    }
}
