using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DatatermLoginGameController : BaseBunkerComputerGameController
	{
		private CName _loopAnimName;
		private inkWidgetReference _alphaSys;
		private inkWidgetReference _bravoSys;
		private inkWidgetReference _sierraSys;
		private inkWidgetReference _victorSys;

		[Ordinal(4)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetProperty(ref _loopAnimName);
			set => SetProperty(ref _loopAnimName, value);
		}

		[Ordinal(5)] 
		[RED("alphaSys")] 
		public inkWidgetReference AlphaSys
		{
			get => GetProperty(ref _alphaSys);
			set => SetProperty(ref _alphaSys, value);
		}

		[Ordinal(6)] 
		[RED("bravoSys")] 
		public inkWidgetReference BravoSys
		{
			get => GetProperty(ref _bravoSys);
			set => SetProperty(ref _bravoSys, value);
		}

		[Ordinal(7)] 
		[RED("sierraSys")] 
		public inkWidgetReference SierraSys
		{
			get => GetProperty(ref _sierraSys);
			set => SetProperty(ref _sierraSys, value);
		}

		[Ordinal(8)] 
		[RED("victorSys")] 
		public inkWidgetReference VictorSys
		{
			get => GetProperty(ref _victorSys);
			set => SetProperty(ref _victorSys, value);
		}

		public DatatermLoginGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
