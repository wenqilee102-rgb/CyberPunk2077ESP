using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipModsAttunementData : IScriptable
	{
		private CString _name;
		private CName _icon;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		public MinimalItemTooltipModsAttunementData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
