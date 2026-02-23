using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questContentSwitch_ConditionType : questISystemConditionType
	{
		private CName _switchName;

		[Ordinal(0)] 
		[RED("switchName")] 
		public CName SwitchName
		{
			get => GetProperty(ref _switchName);
			set => SetProperty(ref _switchName, value);
		}

		public questContentSwitch_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
