using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SgMergeSuite.Code.Wrappers
{
	public class TfsPowerToolsWrapper
	{
		static TfsPowerToolsWrapper()
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
		}

		private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			//string folderPath = Path.GetDirectoryName(installPath);
			string assemblyPath = Path.Combine(installPath, new AssemblyName(args.Name).Name + ".dll");
			if (!File.Exists(assemblyPath)) return null;
			Assembly assembly = Assembly.LoadFrom(assemblyPath);
			return assembly;
		}

		static bool? isInstalled = null;
		static string installPath;
		static Assembly tfsCommandRunnerCoreAssembly;
		static MethodInfo runCommand;

		internal static void Init(string serverPath, string workspaceName, IntPtr parentWindowHandle)
		{
			ServerUri = serverPath;
			WorkspaceName = workspaceName;
			ParentWindowHandle = parentWindowHandle;
			CheckInstall();
		}

		private static object runnerInstance;
		public static string WorkspaceName { get; set; }
		public static string ServerUri { get; set; }
		public static IntPtr ParentWindowHandle { get; private set; }

		public TfsPowerToolsWrapper()
		{
		}

		public static bool IsInstalled
		{
			get
			{
				if (isInstalled == null)
					CheckInstall();
				return isInstalled.Value;
			}
		}

		static void CheckInstall()
		{
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), 
				"Microsoft Team Foundation Server 2015 Power Tools");
			if(!Directory.Exists(path))
				path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
					"Microsoft Team Foundation Server 2013 Power Tools");
			if (Directory.Exists(path))
			{
				installPath = path;
				isInstalled = true;
				LoadCommandRunner();
			}
			else
				isInstalled = false;
		}
		static void LoadCommandRunner()
		{
			if (!IsInstalled)
				return;
			tfsCommandRunnerCoreAssembly = Assembly.LoadFile(Path.Combine(installPath, "Microsoft.VisualStudio.TeamFoundation.PowerTools.TfsCommandRunnerCore.dll"));
			var runnerType = tfsCommandRunnerCoreAssembly.GetType("Microsoft.TeamFoundation.PowerTools.TfsCommandRunner.Core.CommandRunnerCore");
			runnerInstance = runnerType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static).GetValue(null);
			runnerInstance.GetType().GetMethod("Initialize", BindingFlags.Public | BindingFlags.Instance)
				.Invoke(runnerInstance, new object[] {
					Process.GetCurrentProcess().Id, 
					ServerUri
				});
			runCommand = runnerType.GetMethod("RunCommandForWorkspace", BindingFlags.Instance | BindingFlags.Public);
		}
		public void Resolve(string path)
		{
			if (!IsInstalled)
				return;
			var cmd = GetCommand("Resolve");
			Run(cmd, path);
		}

		private void Run(Type cmd, string path)
		{
			runCommand.Invoke(runnerInstance, new object[] {
				cmd,
				WorkspaceName,
				new string[] { path },
				ParentWindowHandle
			});
		}

		static Type GetCommand(string name)
		{
			return tfsCommandRunnerCoreAssembly.GetType("Microsoft.TeamFoundation.PowerTools.TfsCommandRunner.Core.Command.Command" + name);
		}

		//public void ChangeSetDetails(int id)
		//{
		//	if (!IsInstalled)
		//		return;
		//	var cmd = GetCommand("Resolve");
		//	Run(cmd);
		//}
		
	}
}
