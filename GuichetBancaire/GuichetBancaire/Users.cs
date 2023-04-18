using System;
using System.Collections.Generic;
using System.Text;

namespace GuichetBancaire
{
    internal class Users
    {
		private string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		private string _prenom;

		public string Prenom
		{
			get { return _prenom; }
			set { _prenom = value; }
		}

		private DateTime _dateNaissance;

		public DateTime DateNaissance
		{
			get { return _dateNaissance; }
			set { _dateNaissance = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		public Users(string nom, string prenom,DateTime dateNaissance, string email)
		{
			this._nom = nom;
			this._prenom = prenom;
			this._dateNaissance = dateNaissance;
			this._email = email;
		}

		public string AfficheCaractUsers()
		{
			string result = "Nom : " + Nom + " Prenom : " + Prenom + " Date de Naissance : " + DateNaissance
				+ " Email " + Email;
			return result;
		}


	}
}
