using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaggerReactionTask : AIHitReactionTask
	{
		private TweakDBID _tweakDBPackage;
		private CBool _tumble;
		private CBool _onUpdateCompleted;

		[Ordinal(4)] 
		[RED("tweakDBPackage")] 
		public TweakDBID TweakDBPackage
		{
			get => GetProperty(ref _tweakDBPackage);
			set => SetProperty(ref _tweakDBPackage, value);
		}

		[Ordinal(5)] 
		[RED("tumble")] 
		public CBool Tumble
		{
			get => GetProperty(ref _tumble);
			set => SetProperty(ref _tumble, value);
		}

		[Ordinal(6)] 
		[RED("onUpdateCompleted")] 
		public CBool OnUpdateCompleted
		{
			get => GetProperty(ref _onUpdateCompleted);
			set => SetProperty(ref _onUpdateCompleted, value);
		}

		public StaggerReactionTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
