using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusScreenGameController : BaseBunkerComputerGameController
	{
		private inkWidgetReference _alphaSys;
		private inkWidgetReference _bravoSys;
		private inkWidgetReference _sierraSys;
		private inkWidgetReference _victorSys;
		private inkWidgetReference _sierraBackupSys;
		private inkWidgetReference _victorBackupSys;

		[Ordinal(4)] 
		[RED("alphaSys")] 
		public inkWidgetReference AlphaSys
		{
			get => GetProperty(ref _alphaSys);
			set => SetProperty(ref _alphaSys, value);
		}

		[Ordinal(5)] 
		[RED("bravoSys")] 
		public inkWidgetReference BravoSys
		{
			get => GetProperty(ref _bravoSys);
			set => SetProperty(ref _bravoSys, value);
		}

		[Ordinal(6)] 
		[RED("sierraSys")] 
		public inkWidgetReference SierraSys
		{
			get => GetProperty(ref _sierraSys);
			set => SetProperty(ref _sierraSys, value);
		}

		[Ordinal(7)] 
		[RED("victorSys")] 
		public inkWidgetReference VictorSys
		{
			get => GetProperty(ref _victorSys);
			set => SetProperty(ref _victorSys, value);
		}

		[Ordinal(8)] 
		[RED("sierraBackupSys")] 
		public inkWidgetReference SierraBackupSys
		{
			get => GetProperty(ref _sierraBackupSys);
			set => SetProperty(ref _sierraBackupSys, value);
		}

		[Ordinal(9)] 
		[RED("victorBackupSys")] 
		public inkWidgetReference VictorBackupSys
		{
			get => GetProperty(ref _victorBackupSys);
			set => SetProperty(ref _victorBackupSys, value);
		}

		public StatusScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
