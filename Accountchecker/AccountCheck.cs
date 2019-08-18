using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountchecker
{
	public class AccountCheck
	{

		List<Account> Accounts;

		public AccountCheck()
		{
			Accounts = new List<Account>()
			{
				new Account{AccountId = 1, Name="Charlie", EmailAddress="blar", Score=10},
				new Account{AccountId = 2, Name="Kyle", EmailAddress="blar2", Score= 9},
				new Account{AccountId = 3, Name="Oliver", EmailAddress="blar3", Score = 8}
			};

			
		}



		public Account Search(int id)
			{

			 return Accounts.Find(a => a.AccountId == id);
			Console.WriteLine(Accounts);
			
			


			
		}


		public void returnList()
		{
			foreach (var item in Accounts)
			{
				Console.WriteLine( "ID: " + item.AccountId  + " " + item.Name);
			}
		}

	}
}
