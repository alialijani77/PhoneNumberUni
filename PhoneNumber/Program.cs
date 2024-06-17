using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PhoneNumber.Data.Context;

namespace PhoneNumber
{
	internal static class Program
	{
		private static void ConfigureServices(IServiceCollection services)
		{
			//#region DbContext
			//services.AddDbContext<MyDbContext>(options => options.
			//UseSqlServer("Data Source = .; Initial Catalog = BankingSystemDB; Integrated Security = true; MultipleActiveResultSets=true; TrustServerCertificate=True"));
			//#endregion
		}
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			
			Application.Run(new Form1());
		}
	}
}