using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSystemGlobalSettings : CVariable
	{
		private CBool _syncLipsyncToSceneTime;

		[Ordinal(0)] 
		[RED("syncLipsyncToSceneTime")] 
		public CBool SyncLipsyncToSceneTime
		{
			get => GetProperty(ref _syncLipsyncToSceneTime);
			set => SetProperty(ref _syncLipsyncToSceneTime, value);
		}

		public scnSceneSystemGlobalSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
