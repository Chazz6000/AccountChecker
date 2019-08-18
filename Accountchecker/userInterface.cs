using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountchecker
{
	public class userInterface
	{
		

		AccountCheck check = new AccountCheck();

		public userInterface(string input)
		{
			Input = input;
			InputCheck(input);
			
		}

		public string Input  { get; set; }

		public Account account { get; set; }

		
		


		public void InputCheck(string input) //Checks the input,
		{
			string list = "Get";
			string sList = "1";

			if(input == list )
			{
				check.returnList();
			
			}

			if(input == sList)
			{
				account = check.Search(Int32.Parse(sList));
				Console.WriteLine(account.Name);
			}
		}


		


	}
}
