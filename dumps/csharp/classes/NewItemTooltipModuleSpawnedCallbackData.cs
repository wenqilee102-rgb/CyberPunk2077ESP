using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipModuleSpawnedCallbackData : IScriptable
	{
		private CName _moduleName;

		[Ordinal(0)] 
		[RED("moduleName")] 
		public CName ModuleName
		{
			get => GetProperty(ref _moduleName);
			set => SetProperty(ref _moduleName, value);
		}

		public NewItemTooltipModuleSpawnedCallbackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
