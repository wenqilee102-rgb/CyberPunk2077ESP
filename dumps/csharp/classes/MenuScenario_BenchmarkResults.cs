using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_BenchmarkResults : MenuScenario_BaseMenu
	{
		private CHandle<inkCallbackConnectorData> _callbackData;

		[Ordinal(4)] 
		[RED("callbackData")] 
		public CHandle<inkCallbackConnectorData> CallbackData
		{
			get => GetProperty(ref _callbackData);
			set => SetProperty(ref _callbackData, value);
		}

		public MenuScenario_BenchmarkResults(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
