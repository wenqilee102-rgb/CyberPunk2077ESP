using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutodriveQuestContentLockListener : questScriptQuestContentLockListener
	{
		private wCHandle<AutoDriveSystem> _autodriveSystem;

		[Ordinal(0)] 
		[RED("autodriveSystem")] 
		public wCHandle<AutoDriveSystem> AutodriveSystem
		{
			get => GetProperty(ref _autodriveSystem);
			set => SetProperty(ref _autodriveSystem, value);
		}

		public AutodriveQuestContentLockListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
