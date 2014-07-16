using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using SEModAPIExtensions.API; //required for plugins
using SEModAPIExtensions.API.Plugin; //required for plugins
using SEModAPIExtensions.API.Plugin.Events; // plugin events

using SEModAPIInternal.Support;
using SEModAPIInternal.API.Common;

namespace SqlPlugin
{
	public class Core : PluginBase
	{
		#region "Attributes"

		// variable definitions
		// access static (string,bool, ect ect) m_variableName;

		private static string m_databaseName;

		#endregion

		#region "Constructors and Initializers

		// Called when the server first launches
		public Core()
		{
			Console.WriteLine("SQL Plugin '" + Id.ToString() + "' constructed!");
		}

		// Called when the server finishes loading
		public override void Init()
		{
			Console.WriteLine("SQL Plugin '" + Id.ToString() + "' initialized!");
			this.ConnectToDatabase();
		}

		#endregion

		#region "Properties"

		// get set variables, options on the properties panel for plugin
		[Category("SQL Database")]
		[Description("The name of the SQL database you want to connect to")]
		[Browsable(true)]
		[ReadOnly(false)]
		public string DatabaseName
		{
			get
			{
				return m_databaseName; // Send m_databaseNames value to the plugins properties panel
			}
			set
			{
				m_databaseName = value; // if the value changes in the code, it updates the plugins properties panel
			}
		}


		#endregion

		#region "Event Handlers"

		// Runs 10 times a second when server is running
		public override void Update()
		{
			// Idk what to put here for an example, look at my MOTDPlugin
		}

		public override void Shutdown()
		{
		}

		#endregion

		#region "Methods"


		private void ConnectToDatabase()
		{
			// try to use try/catch blocks in something that could cause an exception
			try
			{
				// I'm sure failing to connect to a database could cause an exception!
			}
			catch (Exception ex)
			{
				LogManager.APILog.WriteLineAndConsole("SQL Plugin - Error: " + ex.ToString());
			}
		}

		#endregion

	}
}
