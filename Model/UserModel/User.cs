using System.Windows.Controls;

namespace Messager.Model.UserModel
{
    internal class User : IUser
    {
		private string login;
		public string Login
		{
			get { return login; }
			set { login = value; }
		}

		private string password;
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string secondName;
		public string SecondName
		{
			get { return secondName; }
			set { secondName = value; }
		}

		private string phone;
		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		private string email;
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private Image avatar;
		public Image Avatar
		{
			get { return avatar; }
			set { avatar = value; }
		}

		private DateTime birthday;
		public DateTime Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}
		private int pin;

		public int Pin
		{
			get { return pin; }
			set { pin = value; }
		}


	}
}
