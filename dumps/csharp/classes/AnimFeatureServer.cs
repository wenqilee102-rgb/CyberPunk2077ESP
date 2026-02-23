using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeatureServer : animAnimFeature
	{
		private CInt32 _coverState;
		private CInt32 _serverState;

		[Ordinal(0)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get => GetProperty(ref _coverState);
			set => SetProperty(ref _coverState, value);
		}

		[Ordinal(1)] 
		[RED("serverState")] 
		public CInt32 ServerState
		{
			get => GetProperty(ref _serverState);
			set => SetProperty(ref _serverState, value);
		}

		public AnimFeatureServer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
