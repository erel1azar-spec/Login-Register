using CourtInvitor.Models;

namespace CourtInvitor.ModelsLogic
{
    internal class User:UserModel
    {
            public override void Register()
            {
                Preferences.Set(Keys.NameKey, Name);
            }
            public User()
            {
                Name = Preferences.Get(Keys.NameKey, string.Empty);
                Email = Preferences.Get(Keys.EmailKey, string.Empty);
                Pass = Preferences.Get(Keys.PassWord, string.Empty);
            }
        public override bool Login()
        {
            return true;
        }
    }
}
