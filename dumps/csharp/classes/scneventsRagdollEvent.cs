using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsRagdollEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CBool _enableRagdoll;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("enableRagdoll")] 
		public CBool EnableRagdoll
		{
			get => GetProperty(ref _enableRagdoll);
			set => SetProperty(ref _enableRagdoll, value);
		}

		public scneventsRagdollEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
