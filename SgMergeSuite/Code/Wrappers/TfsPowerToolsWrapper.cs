using System;
using System.Collections.Generic;
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
		static bool? isInstalled = null;
		static string installPath;
		static Assembly tfsCommandRunnerCoreAssembly;
		static MethodInfo runCommand;
		private static object runnerInstance;
		public string WorkspaceName { get; private set; }

		public TfsPowerToolsWrapper(string workspaceName)
		{
			this.WorkspaceName = workspaceName;
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
			runCommand = runnerType.GetMethod("RunCommandForWorkspace", BindingFlags.Instance | BindingFlags.Public);
		}
		public void Resolve()
		{
			if (!IsInstalled)
				return;
			var cmd = GetCommand("Resolve");
			Run(cmd);
		}

		private void Run(Type cmd)
		{
			runCommand.Invoke(runnerInstance, new object[] {
				cmd,
				WorkspaceName,
				null,
				null
			});
		}

		static Type GetCommand(string name)
		{
			return tfsCommandRunnerCoreAssembly.GetType("Microsoft.TeamFoundation.PowerTools.TfsCommandRunner.Core.Command." + name);
		}
	}
}
