using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayInitFearAnimation : AIbehaviorconditionScript
	{
		private CBool _grenadePanic;
		private CBool _initialized;

		[Ordinal(0)] 
		[RED("grenadePanic")] 
		public CBool GrenadePanic
		{
			get => GetProperty(ref _grenadePanic);
			set => SetProperty(ref _grenadePanic, value);
		}

		[Ordinal(1)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		public PlayInitFearAnimation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
