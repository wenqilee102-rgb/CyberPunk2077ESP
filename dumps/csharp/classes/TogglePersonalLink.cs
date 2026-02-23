using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TogglePersonalLink : ActionBool
	{
		private CEnum<EPersonalLinkConnectionStatus> _cachedStatus;
		private CBool _shouldSkipMiniGame;

		[Ordinal(39)] 
		[RED("cachedStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> CachedStatus
		{
			get => GetProperty(ref _cachedStatus);
			set => SetProperty(ref _cachedStatus, value);
		}

		[Ordinal(40)] 
		[RED("shouldSkipMiniGame")] 
		public CBool ShouldSkipMiniGame
		{
			get => GetProperty(ref _shouldSkipMiniGame);
			set => SetProperty(ref _shouldSkipMiniGame, value);
		}

		public TogglePersonalLink(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
