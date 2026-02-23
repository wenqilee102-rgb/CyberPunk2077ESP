using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricBoxBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isOverriden;

		[Ordinal(7)] 
		[RED("isOverriden")] 
		public gamebbScriptID_Bool IsOverriden
		{
			get => GetProperty(ref _isOverriden);
			set => SetProperty(ref _isOverriden, value);
		}

		public ElectricBoxBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
